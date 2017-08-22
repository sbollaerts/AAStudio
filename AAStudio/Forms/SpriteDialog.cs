using System;
using System.Windows.Forms;

namespace AAStudio
{
    public partial class SpriteDialog : Form
    {
        #region "Private members"
        private ArtSprite _sprite;
        #endregion

        #region "Constructors"
        public SpriteDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region "Control events"
        private void btOK_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            int i;

            myErrors.Clear();

            if (txtName.Text.Length == 0)
            {
                myErrors.SetError(txtName, Properties.Resources.ERR_EMPTY);
                isValid = false;
            }

            if ((txtWidth.Text.Length == 0) || (int.TryParse(txtWidth.Text, out i) == false))
            {
                myErrors.SetError(txtWidth, Properties.Resources.ERR_NOT_NUMERIC);
                isValid = false;
            }
            else if ((i < 1) || (i > 128))
            {
                myErrors.SetError(txtWidth, string.Format(Properties.Resources.ERR_OUT_OF_RANGE, 1, 128));
                isValid = false;
            }

            if ((txtHeight.Text.Length == 0) || (int.TryParse(txtHeight.Text, out i) == false))
            {
                myErrors.SetError(txtHeight, Properties.Resources.ERR_NOT_NUMERIC);
                isValid = false;
            }
            else if ((i < 1) || (i > 64))
            {
                myErrors.SetError(txtHeight, string.Format(Properties.Resources.ERR_OUT_OF_RANGE, 1, 64));
                isValid = false;
            }

            if (isValid == true)
                DialogResult = DialogResult.OK;
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
                _sprite = value;
                txtName.Text = _sprite.Name;
                txtWidth.Text = _sprite.Width.ToString();
                txtHeight.Text = _sprite.Height.ToString();
            }
        }

        public string SpriteName
        {
            get
            {
                return txtName.Text;
            }
        }

        public int SpriteWidth
        {
            get
            {
                return int.Parse(txtWidth.Text);
            }
        }

        public int SpriteHeight
        {
            get
            {
                return int.Parse(txtHeight.Text);
            }
        }
        #endregion
    }
}
