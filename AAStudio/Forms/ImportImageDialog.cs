using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAStudio
{
    // Transformation black and white
    // https://stackoverflow.com/questions/2746103/what-would-be-a-good-true-black-and-white-colormatrix
    public partial class ImportImageDialog : Form
    {
        #region "Private members"
        private Image _source = null;
        private Bitmap _selection = null;

        private Brush _brushNotSelected = new SolidBrush(Color.FromArgb(64, 0, 0, 0));
        private Brush _brushSelected = new SolidBrush(Color.FromArgb(32, 255, 255, 255));

        private int _topX = 0;
        private int _topY = 0;

        private int _oldX = 0;
        private int _oldY = 0;
        #endregion

        #region "Constructors"
        public ImportImageDialog()
        {
            InitializeComponent();
        }
        #endregion

        #region "Buttons Events"
        private void btBrowse_Click(object sender, EventArgs e)
        {
            if (myOpenDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = myOpenDialog.FileName;

                _source = Image.FromFile(txtFile.Text);
                _selection = new Bitmap(_source.Width, _source.Height);
                imgPicture.Image = _selection;
                _topX = 0;
                _topY = 0;
                panel1.AutoScrollPosition = new Point(0, 0);

                imgPicture.Refresh();
                panelPreview.Refresh();
            }
        }
        private void btUp_Click(object sender, EventArgs e)
        {
            if (_topY > 0)
            {
                _topY--;
                imgPicture.Refresh();
                panelPreview.Refresh();
            }
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            if (_topX + (int)txtWidth.Value < _source.Width - 1)
            {
                _topX++;
                imgPicture.Refresh();
                panelPreview.Refresh();
            }
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            if (_topX > 0)
            {
                _topX--;
                imgPicture.Refresh();
                panelPreview.Refresh();
            }
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            if (_topY + (int)txtHeight.Value < _source.Height - 1)
            {
                _topY++;
                imgPicture.Refresh();
                panelPreview.Refresh();
            }
        }
        #endregion

        private void ImportImageDialog_Resize(object sender, EventArgs e)
        {
            if (imgPicture.Image == null)
            {
                imgPicture.Width = panel1.Width;
                imgPicture.Height = panel1.Height;
            }
        }

        private void imgPicture_Paint(object sender, PaintEventArgs e)
        {
            if (_source == null)
                return;

            using (Graphics g = Graphics.FromImage(_selection))
            {
                g.Clear(Color.FromKnownColor(KnownColor.AppWorkspace));
                g.DrawImage(_source, 0, 0);

                // Top Left
                g.FillRectangle(_brushNotSelected, 0, 0, _topX, _topY);
                // Top
                g.FillRectangle(_brushNotSelected, _topX, 0, (int)txtWidth.Value, _topY);
                // Top Right
                g.FillRectangle(_brushNotSelected, _topX + (int)txtWidth.Value, 0, _source.Width - (_topX + (int)txtWidth.Value), _topY);
                // Left
                g.FillRectangle(_brushNotSelected, 0, _topY, _topX, (int)txtHeight.Value);
                // Center
                g.FillRectangle(_brushSelected, _topX, _topY, (int)txtWidth.Value, (int)txtHeight.Value);
                // Right
                g.FillRectangle(_brushNotSelected, _topX + (int)txtWidth.Value, _topY, _source.Width - (_topX + (int)txtWidth.Value), (int)txtHeight.Value);
                // Bottom Left
                g.FillRectangle(_brushNotSelected, 0, _topY + (int)txtHeight.Value, _topX, _source.Height - (_topY + (int)txtHeight.Value));
                // Bottom
                g.FillRectangle(_brushNotSelected, _topX, _topY + (int)txtHeight.Value, (int)txtWidth.Value, _source.Height - (_topY + (int)txtHeight.Value));
                // Bottom Right
                g.FillRectangle(_brushNotSelected, _topX + (int)txtWidth.Value, _topY + (int)txtHeight.Value, _source.Width - (_topX + (int)txtWidth.Value), _source.Height - (_topY + (int)txtHeight.Value));
            }
            e.Graphics.DrawImage(_selection, 0, 0);
        }

        private void imgPicture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _topX = e.X;
                _topY = e.Y;
            }
            _oldX = e.X;
            _oldY = e.Y;
        }

        private void imgPicture_MouseMove(object sender, MouseEventArgs e)
        {
            int deltaX, deltaY, newX, newY;


            if (e.Button != MouseButtons.None)
            {
                deltaX = e.X - _oldX;
                deltaY = e.Y - _oldY;
                newX = _topX + deltaX;
                newY = _topY + deltaY;

                if (newX > _source.Width - (int)txtWidth.Value)
                    newX = _source.Width - (int)txtWidth.Value;
                if (newX < 0)
                    newX = 0;

                if (newY > _source.Height - (int)txtHeight.Value)
                    newY = _source.Height - (int)txtHeight.Value;
                if (newY < 0)
                    newY = 0;

                _oldX += deltaX;
                _oldY += deltaY;

                _topX = newX;
                _topY = newY;

                imgPicture.Refresh();
                panelPreview.Refresh();
            }
        }

        private void txtWidth_ValueChanged(object sender, EventArgs e)
        {
            imgPicture.Refresh();
            panelPreview.Refresh();
        }

        private void panelPreview_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.FromKnownColor(KnownColor.AppWorkspace));
            if (_source == null)
                return;

            var gray_matrix = new float[][] {
                new float[] { 0.299f, 0.299f, 0.299f, 0, 0 },
                new float[] { 0.587f, 0.587f, 0.587f, 0, 0 },
                new float[] { 0.114f, 0.114f, 0.114f, 0, 0 },
                new float[] { 0,      0,      0,      1, 0 },
                new float[] { 0,      0,      0,      0, 1 }
            };

            var ia = new System.Drawing.Imaging.ImageAttributes();
            ia.SetColorMatrix(new System.Drawing.Imaging.ColorMatrix(gray_matrix));
            //            ia.SetThreshold(0.2f); // Change this threshold as needed
            float t = sliderAlpha.Value / 100f;
            ia.SetThreshold(t); // Change this threshold as needed
            e.Graphics.Clear(Color.Black);
            e.Graphics.DrawImage(
                _selection,
                new Rectangle(0, 0, (int)txtWidth.Value, (int)txtHeight.Value),
                _topX,
                _topY,
                (int)txtWidth.Value,
                (int)txtHeight.Value,
                GraphicsUnit.Pixel,
                ia);
        }

        private void sliderAlpha_Scroll(object sender, EventArgs e)
        {
            panelPreview.Refresh();
        }

        private void txtHeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                imgPicture.Refresh();
                panelPreview.Refresh();
                e.SuppressKeyPress = true;
            }

        }
    }
}
