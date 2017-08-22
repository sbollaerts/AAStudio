using System;
using System.Collections;
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
        private string _note = null;
        private BitArray _data = new BitArray(128 * 64);

        #endregion

        #region "Constructors"
        public ArtSprite(string name, int width, int height)
        {
            _name = CleanName(name);
            _width = width;
            _height = height;
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

        public bool GetPixel(int x, int y)
        {
            return _data.Get(y * 128 + x);
        }

        public void SetPixel(int x, int y, bool value, bool refresh = true)
        {
            int offset;

            offset = y * 128 + x;
            if ((x >= 0) && (x < _width) && (y >= 0) && (y < Height))
                if (_data.Get(offset) != value)
                {
                    _data.Set(offset, value);
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
                    b = (byte)((_data.Get(y * 128 + x) == false ? 0 : 1)
                        + ((_data.Get((y + 1) * 128 + x) == false ? 0 : 1) << 1)
                        + ((_data.Get((y + 2) * 128 + x) == false ? 0 : 1) << 2)
                        + ((_data.Get((y + 3) * 128 + x) == false ? 0 : 1) << 3)
                        + ((_data.Get((y + 4) * 128 + x) == false ? 0 : 1) << 4)
                        + ((_data.Get((y + 5) * 128 + x) == false ? 0 : 1) << 5)
                        + ((_data.Get((y + 6) * 128 + x) == false ? 0 : 1) << 6)
                        + ((_data.Get((y + 7) * 128 + x) == false ? 0 : 1) << 7));
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
            _data.Not();
            //for (int x = 0; x < _width; x++)
            //    for (int y = 0; y < _height; y++)
            //        _data.Set(y * 128 + x, !_data.Get(y * 128 + x));
            if (OnPictureChanged != null)
                OnPictureChanged(this, new OnPictureChangeEventArgs());
        }

        public ArtSprite Duplicate()
        {
            ArtSprite rc;

            rc = new ArtSprite(
                string.Format("{0}_copy", _name),
                _width,
                _height);
            rc._note = _note;
            rc._data = (BitArray)_data.Clone();
            //for (int x = 0; x < 128; x++)
            //    for (int y = 0; y < 64; y++)
            //        rc._data[x, y] = _data[x, y];
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
            bool swap;

            for (int x = 0; x < (_width / 2); x++)
                for (int y = 0; y < _height; y++)
                {
                    swap = _data.Get(y * 128 + x);
                    _data.Set(y * 128 + x, _data.Get((y * 128) + (_width - 1 - x)));
                    _data.Set((y * 128) + (_width - 1 - x), swap);
                }
        }

        private void FlipVertical()
        {
            bool swap;

            for (int x = 0; x < _width; x++)
                for (int y = 0; y < (_height / 2); y++)
                {
                    swap = _data.Get(y * 128 + x);
                    _data.Set(y * 128 + x, _data.Get((_height - 1 - y) * 128 + x));
                    _data.Set((_height - 1 - y) * 128 + x, swap);
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
        public BitArray Data
        {
            get { return _data; }
        }
        #endregion
    }
}
