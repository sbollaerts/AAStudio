using System;
using System.Reflection;
using System.Windows.Forms;
using System.Text;
#if DEBUG
using System.Diagnostics;
#endif
namespace AAStudio
{
    public partial class MainForm : Form
    {
        #region "Private Members"
        private ArtFile _file;
        #endregion

        #region "Constructors"
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        #region "Event handlers"
        private void SpriteSelectedHandler(object sender, OnSpriteSelectedEventArgs e)
        {
            paneInformation.Sprite = e.Sprite;
            paneContent.Sprite = e.Sprite;
        }
        #endregion

        #region "Form Events"
        private void MainForm_Load(object sender, EventArgs e)
        {
            menuToolbar.Checked = myToolbar.Visible;
            menuStatusbar.Checked = myStatusbar.Visible;
            menuPaneExplorer.Checked = paneExplorer.Visible;
            menuPaneInformation.Checked = paneInformation.Visible;
            menuPaneDebug.Checked = paneDebug.Visible;
            menuShowGrid.Checked = Properties.Settings.Default.ShowGrid;
            btShowGrid.Checked = menuShowGrid.Checked;
            paneContent.ShowGrid = menuShowGrid.Checked;

            // Bug: visibility of the panels is not set correctly if the 
            //      WindowState is set to Maximized at design-time or at 
            //      run-time with property-bindings... As a work around, 
            //      set this property manually after the screen has loaded. 
            Width = Properties.Settings.Default.Width;
            Height = Properties.Settings.Default.Height;
            WindowState = Properties.Settings.Default.WindowState;

            Text = string.Format(
                "{0} (version {1})",
                ((AssemblyTitleAttribute)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute), false))?.Title ?? "Unknown Title",
                Application.ProductVersion);

            menuNew_Click(null, null);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !DEBUG
            if (MessageBox.Show("Do you really want to quit?", "Quit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
                return;

            }
#endif
            Properties.Settings.Default.WindowState = WindowState;
            Properties.Settings.Default.Width = Width;
            Properties.Settings.Default.Height = Height;
            Properties.Settings.Default.ToolbarVisible = myToolbar.Visible;
            Properties.Settings.Default.StatusbarVisible = myStatusbar.Visible;
            Properties.Settings.Default.ExplorerVisible = paneExplorer.Visible;
            Properties.Settings.Default.InformationVisible = paneInformation.Visible;
            Properties.Settings.Default.DebugVisible = paneDebug.Visible;
            Properties.Settings.Default.ShowGrid = menuShowGrid.Checked;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region "Controls Events"
        private void paneContent_OnMouseMoved(object sender, OnMouseMoveEventArgs e)
        {
            if (e.Pressed == false)
                myMouse.Text = string.Format(
                    "(X:{0}, Y:{1})",
                    (e.X0 == -1 ? "-" : e.X0.ToString()),
                    (e.Y0 == -1 ? "-" : e.Y0.ToString()));
            else
                myMouse.Text = string.Format(
                    "(X:{0}, Y:{1}) -> (X:{2}, Y:{3})",
                    e.X0,
                    e.Y0,
                    e.X1,
                    e.Y1);
        }
        #endregion

        #region "Menu & Toolbar Events"
        #region "Menu & Toolbar - File Management"
        private void menuNew_Click(object sender, EventArgs e)
        {
            RefreshFile(new ArtFile());
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            menuNew_Click(sender, e);
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            ArtFile newFile;

            if (myOpenDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    newFile = ArtFile.Load(myOpenDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format(
                        "The file '{0}' cannot be loaded.",
                        myOpenDialog.FileName));
#if DEBUG
                    Debug.WriteLine(ex.ToString());
#endif
                    return;
                }

                RefreshFile(newFile);
            }
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            menuOpen_Click(sender, e);
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_file.FilePath))
                menuSaveAs_Click(sender, e);
            else
                _file.Save();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            menuSave_Click(sender, e);
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            if (mySaveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _file.SaveAs(mySaveDialog.FileName);
                    Text = string.Format("ARDUBOY Art Studio - {0}", _file.Name);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("The file could not be saved");
#if DEBUG
                    Debug.WriteLine(ex.ToString());
#endif
                }
            }
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region "Menu & Toolbar - Edit Management"
        private void menuAddSprite_Click(object sender, EventArgs e)
        {
            SpriteDialog dlg;

            dlg = new SpriteDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
                paneExplorer.AddSprite(
                    dlg.SpriteName,
                    dlg.SpriteWidth,
                    dlg.SpriteHeight,
                    dlg.SpriteDepth);
        }

        private void btAddSprite_Click(object sender, EventArgs e)
        {
            menuAddSprite_Click(sender, e);
        }

        private void menuDeleteSprite_Click(object sender, EventArgs e)
        {

            if ((paneExplorer.SelectedSprite != null) && (MessageBox.Show(
                String.Format("Are you sure you want to delete the sprite '{0}'?", paneExplorer.SelectedSprite.Name),
                "Delete sprite",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes))
                paneExplorer.DeleteCurrentSprite();
        }

        private void btDeleteSprite_Click(object sender, EventArgs e)
        {
            menuDeleteSprite_Click(sender, e);
        }
        #endregion

        #region "Menu & Toolbar - View Management"
        private void menuToolbar_Click(object sender, EventArgs e)
        {
            menuToolbar.Checked = !menuToolbar.Checked;
            myToolbar.Visible = menuToolbar.Checked;
            menuToolbar.Checked = Properties.Settings.Default.ToolbarVisible;
        }

        private void menuStatusbar_Click(object sender, EventArgs e)
        {
            menuStatusbar.Checked = !menuStatusbar.Checked;
            myStatusbar.Visible = menuStatusbar.Checked;
            menuStatusbar.Checked = Properties.Settings.Default.StatusbarVisible;
        }

        private void menuPaneDebug_Click(object sender, EventArgs e)
        {
            menuPaneDebug.Checked = !menuPaneDebug.Checked;
            paneDebug.Visible = menuPaneDebug.Checked;
            menuPaneDebug.Checked = Properties.Settings.Default.DebugVisible;
        }

        private void menuPaneExplorer_Click(object sender, EventArgs e)
        {
            menuPaneExplorer.Checked = !menuPaneExplorer.Checked;
            paneExplorer.Visible = menuPaneExplorer.Checked;
            menuPaneExplorer.Checked = Properties.Settings.Default.ExplorerVisible;
        }

        private void menuPaneInformation_Click(object sender, EventArgs e)
        {
            menuPaneInformation.Checked = !menuPaneInformation.Checked;
            paneInformation.Visible = menuPaneInformation.Checked;
            menuPaneInformation.Checked = Properties.Settings.Default.InformationVisible;
        }

        private void menuShowGrid_Click(object sender, EventArgs e)
        {
            menuShowGrid.Checked = !menuShowGrid.Checked;
            btShowGrid.Checked = menuShowGrid.Checked;
            paneContent.ShowGrid = menuShowGrid.Checked;
        }

        private void btShowGrid_Click(object sender, EventArgs e)
        {
            menuShowGrid_Click(sender, e);
        }
        #endregion

        #region "Menu & Toolbar - Tools Management"
        private void menuNone_Click(object sender, EventArgs e)
        {
            SelectTool(DrawingTools.None);
        }

        private void btNone_Click(object sender, EventArgs e)
        {
            menuNone_Click(sender, e);
        }

        private void menuDoSelect_Click(object sender, EventArgs e)
        {
            SelectTool(DrawingTools.DoSelect);
        }

        private void btDoSelect_Click(object sender, EventArgs e)
        {
            menuDoSelect_Click(sender, e);
        }

        private void menuToolMove_Click(object sender, EventArgs e)
        {
            SelectTool(DrawingTools.DoMove);
        }

        private void btToolMove_Click(object sender, EventArgs e)
        {
            menuToolMove_Click(sender, e);
        }

        private void menuDoCopySprite_Click(object sender, EventArgs e)
        {
            String s;

            if (paneExplorer.SelectedSprite != null)
            {
                s = paneExplorer.SelectedSprite.Export();
                paneDebug.Print(s.Insert(0, "Sprite copied in the clipboard:\r\n").Replace("\r\n", "\r\n\t"));
                Clipboard.SetText(s);
            }
        }

        private void btDoCopySprite_Click(object sender, EventArgs e)
        {
            menuDoCopySprite_Click(sender, e);
        }

        private void menuDoCopyProject_Click(object sender, EventArgs e)
        {
            String s;

            s = _file.Export();
            if (String.IsNullOrEmpty(s) == false)
            {
                paneDebug.Print(s.Insert(0, "Project copied in the clipboard:\r\n").Replace("\r\n", "\r\n\t"));
                Clipboard.SetText(s);
            }
        }

        private void btDoCopyProject_Click(object sender, EventArgs e)
        {
            menuDoCopyProject_Click(sender, e);
        }

        private void menuDoVideoInvert_Click(object sender, EventArgs e)
        {
            paneExplorer.DoVideoInvert();
        }

        private void btDoVideoInvert_Click(object sender, EventArgs e)
        {
            menuDoVideoInvert_Click(sender, e);
        }

        private void menuDrawPixel_Click(object sender, EventArgs e)
        {
            SelectTool(DrawingTools.DrawPixel);
        }

        private void btDrawPixel_Click(object sender, EventArgs e)
        {
            menuDrawPixel_Click(sender, e);
        }

        private void menuDrawLine_Click(object sender, EventArgs e)
        {
            SelectTool(DrawingTools.DrawLine);
        }

        private void btDrawLine_Click(object sender, EventArgs e)
        {
            menuDrawLine_Click(sender, e);
        }

        private void menuDrawRect_Click(object sender, EventArgs e)
        {
            SelectTool(DrawingTools.DrawRect);
        }

        private void btDrawRect_Click(object sender, EventArgs e)
        {
            menuDrawRect_Click(sender, e);
        }

        private void menuDrawFilledRect_Click(object sender, EventArgs e)
        {
            SelectTool(DrawingTools.DrawFilledRect);
        }

        private void btDrawFilledRect_Click(object sender, EventArgs e)
        {
            menuDrawFilledRect_Click(sender, e);
        }
        #endregion
        #endregion

        #region "Methods"
        private void RefreshFile(ArtFile newFile)
        {
            _file = newFile;
            Text = string.Format("ARDUBOY Art Studio - {0}", _file.Name);
            paneExplorer.File = _file;
            paneDebug.File = _file;
        }

        private void SelectTool(DrawingTools tool)
        {
            // TODO: improve that...!
            menuNone.Checked = false;
            btNone.Checked = false;

            menuDoSelect.Checked = false;
            btDoSelect.Checked = false;

            menuDoMove.Checked = false;
            btDoMove.Checked = false;

            menuDrawPixel.Checked = false;
            btDrawPixel.Checked = false;

            menuDrawLine.Checked = false;
            btDrawLine.Checked = false;

            menuDrawRect.Checked = false;
            btDrawRect.Checked = false;

            menuDrawFilledRect.Checked = false;
            btDrawFilledRect.Checked = false;

            switch (tool)
            {
                case DrawingTools.None:
                    menuNone.Checked = true;
                    btNone.Checked = true;
                    break;
                case DrawingTools.DoSelect:
                    menuDoSelect.Checked = true;
                    btDoSelect.Checked = true;
                    break;
                case DrawingTools.DrawPixel:
                    menuDrawPixel.Checked = true;
                    btDrawPixel.Checked = true;
                    break;
                case DrawingTools.DrawLine:
                    menuDrawLine.Checked = true;
                    btDrawLine.Checked = true;
                    break;
                case DrawingTools.DrawRect:
                    menuDrawRect.Checked = true;
                    btDrawRect.Checked = true;
                    break;
                case DrawingTools.DrawFilledRect:
                    menuDrawFilledRect.Checked = true;
                    btDrawFilledRect.Checked = true;
                    break;
                case DrawingTools.DoMove:
                    menuDoMove.Checked = true;
                    btDoMove.Checked = true;
                    break;
#if DEBUG
                default:
                    throw new NotImplementedException();
#endif
            }

            paneContent.CurrentTool = tool;
        }
        #endregion

        private void menuDoDuplicate_Click(object sender, EventArgs e)
        {
            paneExplorer.DuplicateSprite();
        }

        private void btDoDuplicate_Click(object sender, EventArgs e)
        {
            menuDoDuplicate_Click(sender, e);
        }

        private void menuDoFlipHorizontal_Click(object sender, EventArgs e)
        {
            if (paneExplorer.SelectedSprite != null)
                paneExplorer.SelectedSprite.Flip(FlipModes.Horizontal);
        }

        private void btDoFlipHorizontal_Click(object sender, EventArgs e)
        {
            menuDoFlipHorizontal_Click(sender, e);
        }

        private void menuDoFlipVertical_Click(object sender, EventArgs e)
        {
            if (paneExplorer.SelectedSprite != null)
                paneExplorer.SelectedSprite.Flip(FlipModes.Vertical);
        }

        private void btDoFlipVertical_Click(object sender, EventArgs e)
        {
            menuDoFlipVertical_Click(sender, e);
        }

        private void menuImport_Click(object sender, EventArgs e)
        {
            ImportImageDialog dlg;

            dlg = new ImportImageDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
