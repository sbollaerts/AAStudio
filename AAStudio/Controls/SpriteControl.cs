using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAStudio
{
    public partial class SpriteControl : UserControl
    {
        #region "Private members"
        private ArtSprite _sprite;
        private bool _selected;
        #endregion

        #region "Constructors"
        public SpriteControl()
        {
            InitializeComponent();
        }
        #endregion

        #region "Events"
        public event SpriteSelectedHandler OnSpriteSelected;
        #endregion

        #region "Event handlers"
        private void DataChangedHandler(object sender, OnDataChangedEventArgs e)
        {
            RefreshData();
        }
        #endregion

        #region "Methods"
        private void RefreshData()
        {
            if (_sprite != null)
            {
                lblName.Text = _sprite.Name;
                lblDimension.Text = string.Format(
                    "{0} x {1} (depth: {2})",
                    _sprite.Width,
                    _sprite.Height,
                    _sprite.Depth);
            }
            else
            {
                lblName.Text = "(no data)";
                lblDimension.Text = "(no data)";
            }
        }
        #endregion

        #region "Properties"
        public ArtSprite Sprite
        {
            get
            {
                return _sprite;
            }

            set
            {
                if (DesignMode)
                    return;
                if (_sprite != value)
                {
                    if (_sprite != null)
                        _sprite.OnDataChanged -= DataChangedHandler;
                    _sprite = value;
                    if (_sprite != null)
                        _sprite.OnDataChanged += DataChangedHandler;
                    RefreshData();
                }
            }
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }

            set
            {
                _selected = value;
                BackColor = _selected == true ? Color.FromKnownColor(KnownColor.ActiveCaption) : Color.FromKnownColor(KnownColor.Control);
                if ((OnSpriteSelected != null) && (_selected == true))
                    OnSpriteSelected(this, new OnSpriteSelectedEventArgs(_sprite));
            }
        }
        #endregion

        private void SpriteControl_Click(object sender, EventArgs e)
        {
            Selected = true;
        }
    }
}
