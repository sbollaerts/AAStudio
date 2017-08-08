using System;
using System.Reflection;
using System.Windows.Forms;

namespace AAStudio
{
    public partial class DebugSidebar : UserControl
    {
        #region "Private members"
        private ArtFile _file;
        #endregion

        #region "Constructors"
        public DebugSidebar()
        {
            InitializeComponent();
        }
        #endregion

        #region "Control events"
        private void MessageControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                Print(String.Format(
                    "Starting {0} version {1}",
                    Application.ProductName,
                    Assembly.GetExecutingAssembly().GetName().Version));
        }
        #endregion

        #region "Methods"
        public void Print(string message)
        {
            myMessage.Text = string.Format(
                "[{0:dd/MM/yyyy HH:mm:ss,ffff}] {1}\r\n{2}",
                DateTime.Now,
                message,
                myMessage.Text);
            myMessage.SelectionStart = 0;
        }
        #endregion

        #region "Properties"
        public ArtFile File
        {
            get { return _file; }
            set
            {
                _file = value;
                if ((!DesignMode) && (_file != null))
                    Print(string.Format("File '{0}' loaded", _file.Name));
            }
        }
        #endregion
    }
}
