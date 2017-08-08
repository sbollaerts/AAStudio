using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAStudio
{
    public class OnMouseMoveEventArgs : EventArgs
    {
        #region "Private members"
        private bool _pressed;
        private int _x0, _y0, _x1, _y1;
        #endregion

        #region "Constructors"
        public OnMouseMoveEventArgs(bool pressed, int x0, int y0, int x1, int y1)
        {
            _pressed = pressed;
            _x0 = x0;
            _y0 = y0;
            _x1 = x1;
            _y1 = y1;
        }
        #endregion

        #region "Properties"
        public bool Pressed
        {
            get
            {
                return _pressed;
            }
        }

        public int X0
        {
            get
            {
                return _x0;
            }
        }

        public int Y0
        {
            get
            {
                return _y0;
            }
        }

        public int X1
        {
            get
            {
                return _x1;
            }
        }

        public int Y1
        {
            get
            {
                return _y1;
            }
        }
        #endregion
    }
}
