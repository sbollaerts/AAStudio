using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAStudio
{
    public class OnNotifyEventArgs : EventArgs
    {
        #region "Members"
        private string _source;
        private string _notification;
        #endregion

        #region "Constructors"
        public OnNotifyEventArgs(string source, string notification)
        {
            _source = source;
            _notification = notification;
        }
        #endregion

        #region "Constructors"
        public string Notification
        {
            get { return _notification; }
        }

        public string Source
        {
            get { return _source; }
        }
        #endregion
    }
}
