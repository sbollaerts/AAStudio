using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAStudio
{
    public class OnSpriteSelectedEventArgs : EventArgs
    {
        #region "Private members"
        private int _position;
        private ArtSprite _sprite;
        #endregion

        #region "Constructors"
        public OnSpriteSelectedEventArgs(int position, ArtSprite sprite)
        {
            _position = position;
            _sprite = sprite;
        }

        public OnSpriteSelectedEventArgs(ArtSprite sprite)
        {
            _position = -1;
            _sprite = sprite;
        }
        #endregion

        #region "Properties"
        public int Position
        {
            get
            {
                return _position;
            }
        }

        public ArtSprite Sprite
        {
            get
            {
                return _sprite;
            }
        }
        #endregion
    }
}
