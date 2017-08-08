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
    public partial class InformationSidebar : UserControl
    {
        Brush brushBackground = new SolidBrush(Color.Black);
        Brush brushForeground = new SolidBrush(Color.White);

        #region "Private members"
        private ArtSprite _sprite;
        #endregion

        #region "Constructors"
        public InformationSidebar()
        {
            InitializeComponent();
        }
        #endregion

        #region "Custom event handlers"
        private void PictureChangedHandler(object sender, OnPictureChangeEventArgs e)
        {
            Refresh();
        }
        #endregion

        #region "Control event handlers"
        private void picPreview_Paint(object sender, PaintEventArgs e)
        {
            int x, y, topX, topY, scale;
            Panel src;

            if (DesignMode)
                return;

            src = (Panel)sender;
            e.Graphics.Clear(Color.FromKnownColor(KnownColor.AppWorkspace));

            if (_sprite == null)
                return;

            // ===============================================================
            // === Draw the background
            // ===============================================================
            // Determine the scale factor for a 128x64 sprite
            x = src.Width / 128;
            y = src.Height / 64;
            scale = Math.Min(x, y);
            // Center the sprite depending on its real size
            topX = (src.Width - _sprite.Width * scale) / 2;
            topY = (src.Height - _sprite.Height * scale) / 2;

                e.Graphics.FillRectangle(
                    brushBackground, 
                    0, 
                    0, 
                    src.Width, 
                    src.Height);

                for (x = 0; x < _sprite.Width; x++)
                    for (y = 0; y < _sprite.Height; y++)
                        if (_sprite.GetPixel(x, y) == 255)
                            e.Graphics.FillRectangle(
                                brushForeground, 
                                topX + x * scale, 
                                topY + y * scale, 
                                scale, 
                                scale);      
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
                        _sprite.OnPictureChanged -= PictureChangedHandler;

                    _sprite = value;
                    myProperty.SelectedObject = _sprite;

                    if (_sprite != null)
                        _sprite.OnPictureChanged += PictureChangedHandler;

                    Refresh();
                }
            }
        }
        #endregion
    }
}
