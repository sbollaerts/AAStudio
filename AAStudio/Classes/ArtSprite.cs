using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Text;

namespace AAStudio
{
    [Serializable()]
    public class ArtSprite
    {
        private const string ALLOWED_CHARS = "abcdefghijklmnopqrstuvwxyz1234567890_";

        #region "Private members"
        private string _name = null;
        private int _width = 128;
        private int _height = 64;
        private int _depth = 1;
        private string _note = null;
        private int[,] _data = new int[128, 64];
        #endregion

        #region "Constructors"
        public ArtSprite(string name, int width, int height, int depth)
        {
            _name = CleanName(name);
            _width = width;
            _height = height;
            _depth = depth;
        }
        #endregion

        #region "Events"
        [field: NonSerialized()]
        public event DataChangedHandler OnDataChanged;

        [field: NonSerialized()]
        public event PictureChangedHandler OnPictureChanged;
        #endregion

        #region "Methods"
        public void Resize(int width, int height)
        {
            // TODO: implement your code here
            _width = width;
            _height = height;

            throw new NotImplementedException();
        }

        public int GetPixel(int x, int y)
        {
            return _data[x, y];
        }

        public void SetPixel(int x, int y, int value, bool refresh = true)
        {
            if ((x >= 0) && (x < _width) && (y >= 0) && (y < Height))
                if (_data[x, y] != value)
                {
                    _data[x, y] = value;
                    if ((refresh == true) && (OnPictureChanged != null))
                        OnPictureChanged(this, new OnPictureChangeEventArgs());
                }
        }

        public void ForceRefresh()
        {
            if (OnPictureChanged != null)
                OnPictureChanged(this, new OnPictureChangeEventArgs());
        }

        private string CleanName(string value)
        {
            string rc = null;
            int i;

            if (string.IsNullOrEmpty(value) == false)
            {
                rc = value.ToLower();
                i = 0;
                while (i < rc.Length)
                {
                    if (ALLOWED_CHARS.IndexOf(rc[i]) == -1)
                        rc = rc.Replace(rc[i].ToString(), "");
                    else
                        i++;
                }
            }

            return rc;
        }

        public string Export()
        {
            StringBuilder rc;
            int yMax;
            byte b;

            rc = new StringBuilder();
            rc.AppendFormat("const unsigned char {0}[] PROGMEM = {{", _name);

            yMax = _height + (_height % 8 == 0 ? 0 : 8 - (_height % 8));
            for (int y = 0; y < yMax; y += 8)
            {
                for (int x = 0; x < _width; x++)
                {
                    b = (byte)((_data[x, y] == 0 ? 0 : 1)
                        + ((_data[x, y + 1] == 0 ? 0 : 1) << 1)
                        + ((_data[x, y + 2] == 0 ? 0 : 1) << 2)
                        + ((_data[x, y + 3] == 0 ? 0 : 1) << 3)
                        + ((_data[x, y + 4] == 0 ? 0 : 1) << 4)
                        + ((_data[x, y + 5] == 0 ? 0 : 1) << 5)
                        + ((_data[x, y + 6] == 0 ? 0 : 1) << 6)
                        + ((_data[x, y + 7] == 0 ? 0 : 1) << 7));
                    rc.AppendFormat("0x{0:X}, ", b);
                }
            }

            rc.Remove(rc.Length - 2, 2);
            rc.AppendLine("};");
            rc.AppendFormat("const int {0}_width = {1};\r\n", _name, _width);
            rc.AppendFormat("const int {0}_height = {1};\r\n", _name, _height);

            return rc.ToString();
        }

        public void VideoInvert()
        {
            for (int x = 0; x < _width; x++)
                for (int y = 0; y < _height; y++)
                    _data[x, y] = _data[x, y] ^ 255;
            if (OnPictureChanged != null)
                OnPictureChanged(this, new OnPictureChangeEventArgs());
        }

        public ArtSprite Duplicate()
        {
            ArtSprite rc;

            rc = new ArtSprite(
                string.Format("{0}_copy", _name),
                _width,
                _height,
                _depth);
            rc._note = _note;
            for (int x = 0; x < 128; x++)
                for (int y = 0; y < 64; y++)
                    rc._data[x, y] = _data[x, y];
            return rc;
        }

        public void Flip(FlipModes mode)
        {
            switch (mode)
            {
                case FlipModes.Horizontal:
                    FlipHorizontal();
                    break;
                case FlipModes.Vertical:
                    FlipVertical();
                    break;
#if DEBUG
                default:
                    throw new NotImplementedException();
#endif
            }
            if (OnPictureChanged != null)
                OnPictureChanged(this, new OnPictureChangeEventArgs());
        }

        private void FlipHorizontal()
        {
            int swap;

            for (int x = 0; x < (_width / 2); x++)
                for (int y = 0; y < _height; y++)
                {
                    swap = _data[x, y];
                    _data[x, y] = _data[_width - 1 - x, y];
                    _data[_width - 1 - x, y] = swap;
                }
        }

        private void FlipVertical()
        {
            int swap;

            for (int x = 0; x < _width; x++)
                for (int y = 0; y < (_height / 2); y++)
                {
                    swap = _data[x, y];
                    _data[x, y] = _data[x, _height - 1 - y];
                    _data[x, _height - 1 - y] = swap;
                }
        }
        #endregion

        #region "Properties"
        [Category("Description")]
        public string Name
        {
            get { return _name; }
            set
            {
                value = CleanName(value);

                if (_name != value)
                {
                    _name = value;
                    if (OnDataChanged != null)
                        OnDataChanged(this, new OnDataChangedEventArgs());
                }
            }
        }

        [Category("Dimension"), Browsable(false)]
        public int Width
        {
            get { return _width; }
        }

        [Category("Dimension"), Browsable(false)]
        public int Height
        {
            get { return _height; }
        }

        [Category("Dimension")]
        public Size Size
        {
            get { return new Size(_width, _height); }
        }

        [Category("Dimension"), Browsable(false)]
        public int Depth
        {
            get { return _depth; }
        }

        [Category("Other"),
            EditorAttribute(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string Note
        {
            get
            {
                return _note;
            }

            set
            {
                _note = value;
            }
        }

        [Browsable(false)]
        public int[,] Data
        {
            get { return _data; }
        }
        #endregion
    }
}
