using System.Windows.Forms;

namespace AAStudio
{
    public partial class ExplorerSidebar : UserControl
    {
        #region "Private members"
        private ArtFile _file;
        private SpriteControl _selectedSprite;
        #endregion

        #region "Constructors"
        public ExplorerSidebar()
        {
            InitializeComponent();
        }
        #endregion

        #region "Events"
        public event SpriteSelectedHandler OnSpriteSelected;
        #endregion

        #region "Methods"
        public void AddSprite(string name, int width, int height)
        {
            ArtSprite newSprite;

            newSprite = new ArtSprite(name, width, height);
            _file.Sprites.Add(newSprite);
            CreateSpriteControl(newSprite);
            ((SpriteControl)panelSprites.Controls[panelSprites.Controls.Count - 1]).Selected = true;
        }

        public void AddSprite(ArtSprite newSprite)
        {
            _file.Sprites.Add(newSprite);
            CreateSpriteControl(newSprite);
            ((SpriteControl)panelSprites.Controls[panelSprites.Controls.Count - 1]).Selected = true;
        }

        public void DeleteCurrentSprite()
        {
            if (_selectedSprite != null)
            {
                _selectedSprite.OnSpriteSelected -= SpriteSelectedHandler;
                _file.Sprites.Remove(_selectedSprite.Sprite);
                panelSprites.Controls.Remove(_selectedSprite);

                _selectedSprite = null;
                if (OnSpriteSelected != null)
                    OnSpriteSelected(this, new OnSpriteSelectedEventArgs(-1, null));
            }
        }

        public void DuplicateSprite()
        {
            ArtSprite newSprite;

            if(_selectedSprite!=null)
            {
                newSprite = _selectedSprite.Sprite.Duplicate();
                _file.Sprites.Add(newSprite);
                CreateSpriteControl(newSprite);
            }
        }

        private void CreateSpriteControl(ArtSprite sprite)
        {
            SpriteControl newSpriteControl = new SpriteControl();
            newSpriteControl.OnSpriteSelected += SpriteSelectedHandler;
            newSpriteControl.Sprite = sprite;
            panelSprites.Controls.Add(newSpriteControl);

        }

        public void DoVideoInvert()
        {
            if (_selectedSprite != null)
                _selectedSprite.Sprite.VideoInvert();
        }
        #endregion

        #region "Event handlers"
        private void SpriteSelectedHandler(object sender, OnSpriteSelectedEventArgs e)
        {
            int position;

            foreach (SpriteControl item in panelSprites.Controls)
                if (item != sender)
                    item.Selected = false;
            _selectedSprite = (SpriteControl)sender;

            position = _file.Sprites.IndexOf(e.Sprite);
            if (OnSpriteSelected != null)
                OnSpriteSelected(this, new OnSpriteSelectedEventArgs(position, e.Sprite));
        }
        #endregion

        #region "Properties"
        public ArtFile File
        {
            get { return _file; }
            set
            {
                if (DesignMode)
                    return;

                _file = value;
                foreach (SpriteControl item in panelSprites.Controls)
                    item.OnSpriteSelected -= SpriteSelectedHandler;
                panelSprites.Controls.Clear();
                _selectedSprite = null;

                if ((_file != null) && (File.Sprites.Count != 0))
                {
                    foreach (ArtSprite item in _file.Sprites)
                        CreateSpriteControl(item);
                    ((SpriteControl)panelSprites.Controls[0]).Selected = true;
                }
                else if (OnSpriteSelected != null)
                    OnSpriteSelected(this, new OnSpriteSelectedEventArgs(-1, null));
            }
        }

        public ArtSprite SelectedSprite
        {
            get
            {
                return _selectedSprite == null ? null : _selectedSprite.Sprite;
            }
        }
        #endregion
    }
}
