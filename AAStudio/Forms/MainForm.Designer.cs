namespace AAStudio
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddSprite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDeleteSprite = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPaneExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaneInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaneDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuShowGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNone = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoMove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDoCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoCopySprite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoCopyProject = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoDuplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoFlip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoFlipHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoFlipVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoVideoInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDrawPixel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawRect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDrawFilledRect = new System.Windows.Forms.ToolStripMenuItem();
            this.splitterBottom = new System.Windows.Forms.Splitter();
            this.splitterLeft = new System.Windows.Forms.Splitter();
            this.paneExplorer = new AAStudio.ExplorerSidebar();
            this.paneDebug = new AAStudio.DebugSidebar();
            this.myStatusbar = new System.Windows.Forms.StatusStrip();
            this.myMouse = new System.Windows.Forms.ToolStripStatusLabel();
            this.myToolbar = new System.Windows.Forms.ToolStrip();
            this.btNew = new System.Windows.Forms.ToolStripButton();
            this.btOpen = new System.Windows.Forms.ToolStripButton();
            this.btSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btAddSprite = new System.Windows.Forms.ToolStripButton();
            this.btDeleteSprite = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btShowGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btNone = new System.Windows.Forms.ToolStripButton();
            this.btDoSelect = new System.Windows.Forms.ToolStripButton();
            this.btDoMove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btDoCopy = new System.Windows.Forms.ToolStripDropDownButton();
            this.btDoCopySprite = new System.Windows.Forms.ToolStripMenuItem();
            this.btDoCopyProject = new System.Windows.Forms.ToolStripMenuItem();
            this.btDoDuplicate = new System.Windows.Forms.ToolStripButton();
            this.btDoVideoInvert = new System.Windows.Forms.ToolStripButton();
            this.btDoFlip = new System.Windows.Forms.ToolStripDropDownButton();
            this.btDoFlipHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.btDoFlipVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btDrawPixel = new System.Windows.Forms.ToolStripButton();
            this.btDrawLine = new System.Windows.Forms.ToolStripButton();
            this.btDrawRect = new System.Windows.Forms.ToolStripButton();
            this.btDrawFilledRect = new System.Windows.Forms.ToolStripButton();
            this.myOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.mySaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.paneInformation = new AAStudio.InformationSidebar();
            this.splitterRight = new System.Windows.Forms.Splitter();
            this.paneContent = new AAStudio.DrawingArea();
            this.myMenu.SuspendLayout();
            this.myStatusbar.SuspendLayout();
            this.myToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // myMenu
            // 
            this.myMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.myMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.myMenu.Location = new System.Drawing.Point(0, 0);
            this.myMenu.Name = "myMenu";
            this.myMenu.Size = new System.Drawing.Size(1006, 24);
            this.myMenu.TabIndex = 0;
            this.myMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.toolStripMenuItem1,
            this.menuOpen,
            this.menuImport,
            this.toolStripMenuItem2,
            this.menuSave,
            this.menuSaveAs,
            this.toolStripMenuItem3,
            this.menuQuit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // menuNew
            // 
            this.menuNew.Image = global::AAStudio.Properties.Resources.ic_palette_black_18dp_1x;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(156, 22);
            this.menuNew.Text = "&New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = global::AAStudio.Properties.Resources.ic_file_upload_black_18dp_1x;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(156, 22);
            this.menuOpen.Text = "&Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuImport
            // 
            this.menuImport.Name = "menuImport";
            this.menuImport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.menuImport.Size = new System.Drawing.Size(156, 22);
            this.menuImport.Text = "Import...";
            this.menuImport.Click += new System.EventHandler(this.menuImport_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
            // 
            // menuSave
            // 
            this.menuSave.Image = global::AAStudio.Properties.Resources.ic_file_download_black_18dp_1x;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(156, 22);
            this.menuSave.Text = "&Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAs
            // 
            this.menuSaveAs.Name = "menuSaveAs";
            this.menuSaveAs.Size = new System.Drawing.Size(156, 22);
            this.menuSaveAs.Text = "Save &as...";
            this.menuSaveAs.Click += new System.EventHandler(this.menuSaveAs_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(153, 6);
            // 
            // menuQuit
            // 
            this.menuQuit.Name = "menuQuit";
            this.menuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuQuit.Size = new System.Drawing.Size(156, 22);
            this.menuQuit.Text = "&Quit";
            this.menuQuit.Click += new System.EventHandler(this.menuQuit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAddSprite,
            this.menuDeleteSprite});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // menuAddSprite
            // 
            this.menuAddSprite.Image = global::AAStudio.Properties.Resources.ic_add_circle_outline_black_18dp_1x;
            this.menuAddSprite.Name = "menuAddSprite";
            this.menuAddSprite.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Insert)));
            this.menuAddSprite.Size = new System.Drawing.Size(190, 22);
            this.menuAddSprite.Text = "&Add sprite";
            this.menuAddSprite.Click += new System.EventHandler(this.menuAddSprite_Click);
            // 
            // menuDeleteSprite
            // 
            this.menuDeleteSprite.Image = global::AAStudio.Properties.Resources.ic_remove_circle_outline_black_18dp_1x;
            this.menuDeleteSprite.Name = "menuDeleteSprite";
            this.menuDeleteSprite.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.menuDeleteSprite.Size = new System.Drawing.Size(190, 22);
            this.menuDeleteSprite.Text = "&Delete sprite";
            this.menuDeleteSprite.Click += new System.EventHandler(this.menuDeleteSprite_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolbar,
            this.menuStatusbar,
            this.toolStripMenuItem4,
            this.menuPaneExplorer,
            this.menuPaneInformation,
            this.menuPaneDebug,
            this.toolStripMenuItem5,
            this.menuShowGrid});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // menuToolbar
            // 
            this.menuToolbar.Name = "menuToolbar";
            this.menuToolbar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F9)));
            this.menuToolbar.Size = new System.Drawing.Size(203, 22);
            this.menuToolbar.Text = "&Toolbar";
            this.menuToolbar.Click += new System.EventHandler(this.menuToolbar_Click);
            // 
            // menuStatusbar
            // 
            this.menuStatusbar.Name = "menuStatusbar";
            this.menuStatusbar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.menuStatusbar.Size = new System.Drawing.Size(203, 22);
            this.menuStatusbar.Text = "&Statusbar";
            this.menuStatusbar.Click += new System.EventHandler(this.menuStatusbar_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(200, 6);
            // 
            // menuPaneExplorer
            // 
            this.menuPaneExplorer.Name = "menuPaneExplorer";
            this.menuPaneExplorer.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.menuPaneExplorer.Size = new System.Drawing.Size(203, 22);
            this.menuPaneExplorer.Text = "Explorer sidebar";
            this.menuPaneExplorer.Click += new System.EventHandler(this.menuPaneExplorer_Click);
            // 
            // menuPaneInformation
            // 
            this.menuPaneInformation.Name = "menuPaneInformation";
            this.menuPaneInformation.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.menuPaneInformation.Size = new System.Drawing.Size(203, 22);
            this.menuPaneInformation.Text = "Information sidebar";
            this.menuPaneInformation.Click += new System.EventHandler(this.menuPaneInformation_Click);
            // 
            // menuPaneDebug
            // 
            this.menuPaneDebug.Name = "menuPaneDebug";
            this.menuPaneDebug.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.menuPaneDebug.Size = new System.Drawing.Size(203, 22);
            this.menuPaneDebug.Text = "Debug window";
            this.menuPaneDebug.Click += new System.EventHandler(this.menuPaneDebug_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(200, 6);
            // 
            // menuShowGrid
            // 
            this.menuShowGrid.Image = global::AAStudio.Properties.Resources.ic_grid_on_black_18dp_1x;
            this.menuShowGrid.Name = "menuShowGrid";
            this.menuShowGrid.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menuShowGrid.Size = new System.Drawing.Size(203, 22);
            this.menuShowGrid.Text = "Grid";
            this.menuShowGrid.Click += new System.EventHandler(this.menuShowGrid_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNone,
            this.menuDoSelect,
            this.menuDoMove,
            this.toolStripMenuItem7,
            this.menuDoCopy,
            this.menuDoDuplicate,
            this.menuDoFlip,
            this.menuDoVideoInvert,
            this.toolStripMenuItem6,
            this.menuDrawPixel,
            this.menuDrawLine,
            this.menuDrawRect,
            this.menuDrawFilledRect});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // menuNone
            // 
            this.menuNone.Image = global::AAStudio.Properties.Resources.ic_visibility_black_18dp_1x;
            this.menuNone.Name = "menuNone";
            this.menuNone.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.menuNone.Size = new System.Drawing.Size(227, 22);
            this.menuNone.Text = "None";
            this.menuNone.Click += new System.EventHandler(this.menuNone_Click);
            // 
            // menuDoSelect
            // 
            this.menuDoSelect.Enabled = false;
            this.menuDoSelect.Image = global::AAStudio.Properties.Resources.ic_photo_size_select_small_black_18dp_1x;
            this.menuDoSelect.Name = "menuDoSelect";
            this.menuDoSelect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menuDoSelect.Size = new System.Drawing.Size(227, 22);
            this.menuDoSelect.Text = "Mark";
            this.menuDoSelect.Click += new System.EventHandler(this.menuDoSelect_Click);
            // 
            // menuDoMove
            // 
            this.menuDoMove.Enabled = false;
            this.menuDoMove.Image = global::AAStudio.Properties.Resources.ic_open_with_black_18dp_1x;
            this.menuDoMove.Name = "menuDoMove";
            this.menuDoMove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuDoMove.Size = new System.Drawing.Size(227, 22);
            this.menuDoMove.Text = "Move";
            this.menuDoMove.Click += new System.EventHandler(this.menuToolMove_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(224, 6);
            // 
            // menuDoCopy
            // 
            this.menuDoCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoCopySprite,
            this.menuDoCopyProject});
            this.menuDoCopy.Image = global::AAStudio.Properties.Resources.ic_content_copy_black_18dp_1x;
            this.menuDoCopy.Name = "menuDoCopy";
            this.menuDoCopy.Size = new System.Drawing.Size(227, 22);
            this.menuDoCopy.Text = "Copy...";
            // 
            // menuDoCopySprite
            // 
            this.menuDoCopySprite.Name = "menuDoCopySprite";
            this.menuDoCopySprite.Size = new System.Drawing.Size(148, 22);
            this.menuDoCopySprite.Text = "Current sprite";
            this.menuDoCopySprite.Click += new System.EventHandler(this.menuDoCopySprite_Click);
            // 
            // menuDoCopyProject
            // 
            this.menuDoCopyProject.Name = "menuDoCopyProject";
            this.menuDoCopyProject.Size = new System.Drawing.Size(148, 22);
            this.menuDoCopyProject.Text = "Whole project";
            this.menuDoCopyProject.Click += new System.EventHandler(this.menuDoCopyProject_Click);
            // 
            // menuDoDuplicate
            // 
            this.menuDoDuplicate.Image = global::AAStudio.Properties.Resources.ic_content_paste_black_18dp_1x;
            this.menuDoDuplicate.Name = "menuDoDuplicate";
            this.menuDoDuplicate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuDoDuplicate.Size = new System.Drawing.Size(227, 22);
            this.menuDoDuplicate.Text = "Duplicate sprite";
            this.menuDoDuplicate.Click += new System.EventHandler(this.menuDoDuplicate_Click);
            // 
            // menuDoFlip
            // 
            this.menuDoFlip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDoFlipHorizontal,
            this.menuDoFlipVertical});
            this.menuDoFlip.Image = global::AAStudio.Properties.Resources.ic_flip_black_18dp_1x;
            this.menuDoFlip.Name = "menuDoFlip";
            this.menuDoFlip.Size = new System.Drawing.Size(227, 22);
            this.menuDoFlip.Text = "Flip...";
            // 
            // menuDoFlipHorizontal
            // 
            this.menuDoFlipHorizontal.Name = "menuDoFlipHorizontal";
            this.menuDoFlipHorizontal.Size = new System.Drawing.Size(129, 22);
            this.menuDoFlipHorizontal.Text = "Horizontal";
            this.menuDoFlipHorizontal.Click += new System.EventHandler(this.menuDoFlipHorizontal_Click);
            // 
            // menuDoFlipVertical
            // 
            this.menuDoFlipVertical.Name = "menuDoFlipVertical";
            this.menuDoFlipVertical.Size = new System.Drawing.Size(129, 22);
            this.menuDoFlipVertical.Text = "Vertical";
            this.menuDoFlipVertical.Click += new System.EventHandler(this.menuDoFlipVertical_Click);
            // 
            // menuDoVideoInvert
            // 
            this.menuDoVideoInvert.Image = global::AAStudio.Properties.Resources.ic_compare_black_18dp_1x;
            this.menuDoVideoInvert.Name = "menuDoVideoInvert";
            this.menuDoVideoInvert.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.menuDoVideoInvert.Size = new System.Drawing.Size(227, 22);
            this.menuDoVideoInvert.Text = "Video Invert";
            this.menuDoVideoInvert.Click += new System.EventHandler(this.menuDoVideoInvert_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(224, 6);
            // 
            // menuDrawPixel
            // 
            this.menuDrawPixel.Image = global::AAStudio.Properties.Resources.ic_mode_edit_black_18dp_1x;
            this.menuDrawPixel.Name = "menuDrawPixel";
            this.menuDrawPixel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuDrawPixel.Size = new System.Drawing.Size(227, 22);
            this.menuDrawPixel.Text = "Pen";
            this.menuDrawPixel.Click += new System.EventHandler(this.menuDrawPixel_Click);
            // 
            // menuDrawLine
            // 
            this.menuDrawLine.Image = global::AAStudio.Properties.Resources.ic_border_color_black_18dp_1x;
            this.menuDrawLine.Name = "menuDrawLine";
            this.menuDrawLine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuDrawLine.Size = new System.Drawing.Size(227, 22);
            this.menuDrawLine.Text = "Line";
            this.menuDrawLine.Click += new System.EventHandler(this.menuDrawLine_Click);
            // 
            // menuDrawRect
            // 
            this.menuDrawRect.Image = global::AAStudio.Properties.Resources.draw_rect;
            this.menuDrawRect.Name = "menuDrawRect";
            this.menuDrawRect.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuDrawRect.Size = new System.Drawing.Size(227, 22);
            this.menuDrawRect.Text = "Rectangle";
            this.menuDrawRect.Click += new System.EventHandler(this.menuDrawRect_Click);
            // 
            // menuDrawFilledRect
            // 
            this.menuDrawFilledRect.Image = global::AAStudio.Properties.Resources.fill_rect;
            this.menuDrawFilledRect.Name = "menuDrawFilledRect";
            this.menuDrawFilledRect.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.menuDrawFilledRect.Size = new System.Drawing.Size(227, 22);
            this.menuDrawFilledRect.Text = "Filled rectangle";
            this.menuDrawFilledRect.Click += new System.EventHandler(this.menuDrawFilledRect_Click);
            // 
            // splitterBottom
            // 
            this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterBottom.Enabled = false;
            this.splitterBottom.Location = new System.Drawing.Point(0, 546);
            this.splitterBottom.Name = "splitterBottom";
            this.splitterBottom.Size = new System.Drawing.Size(1006, 3);
            this.splitterBottom.TabIndex = 19;
            this.splitterBottom.TabStop = false;
            // 
            // splitterLeft
            // 
            this.splitterLeft.Enabled = false;
            this.splitterLeft.Location = new System.Drawing.Point(220, 51);
            this.splitterLeft.Name = "splitterLeft";
            this.splitterLeft.Size = new System.Drawing.Size(3, 495);
            this.splitterLeft.TabIndex = 21;
            this.splitterLeft.TabStop = false;
            // 
            // paneExplorer
            // 
            this.paneExplorer.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::AAStudio.Properties.Settings.Default, "ExplorerVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.paneExplorer.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneExplorer.File = null;
            this.paneExplorer.Location = new System.Drawing.Point(0, 51);
            this.paneExplorer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneExplorer.Name = "paneExplorer";
            this.paneExplorer.Size = new System.Drawing.Size(220, 495);
            this.paneExplorer.TabIndex = 20;
            this.paneExplorer.Visible = global::AAStudio.Properties.Settings.Default.ExplorerVisible;
            this.paneExplorer.OnSpriteSelected += new AAStudio.SpriteSelectedHandler(this.SpriteSelectedHandler);
            // 
            // paneDebug
            // 
            this.paneDebug.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::AAStudio.Properties.Settings.Default, "DebugVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.paneDebug.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneDebug.File = null;
            this.paneDebug.Location = new System.Drawing.Point(0, 549);
            this.paneDebug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneDebug.Name = "paneDebug";
            this.paneDebug.Size = new System.Drawing.Size(1006, 150);
            this.paneDebug.TabIndex = 18;
            this.paneDebug.Visible = global::AAStudio.Properties.Settings.Default.DebugVisible;
            // 
            // myStatusbar
            // 
            this.myStatusbar.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::AAStudio.Properties.Settings.Default, "StatusbarVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.myStatusbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.myStatusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myMouse});
            this.myStatusbar.Location = new System.Drawing.Point(0, 699);
            this.myStatusbar.Name = "myStatusbar";
            this.myStatusbar.Size = new System.Drawing.Size(1006, 22);
            this.myStatusbar.TabIndex = 2;
            this.myStatusbar.Text = "statusStrip1";
            this.myStatusbar.Visible = global::AAStudio.Properties.Settings.Default.StatusbarVisible;
            // 
            // myMouse
            // 
            this.myMouse.Name = "myMouse";
            this.myMouse.Size = new System.Drawing.Size(46, 17);
            this.myMouse.Text = "X: - Y: -";
            // 
            // myToolbar
            // 
            this.myToolbar.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::AAStudio.Properties.Settings.Default, "ToolbarVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.myToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.myToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btNew,
            this.btOpen,
            this.btSave,
            this.toolStripSeparator1,
            this.btAddSprite,
            this.btDeleteSprite,
            this.toolStripSeparator2,
            this.btShowGrid,
            this.toolStripSeparator3,
            this.btNone,
            this.btDoSelect,
            this.btDoMove,
            this.toolStripSeparator5,
            this.btDoCopy,
            this.btDoDuplicate,
            this.btDoVideoInvert,
            this.btDoFlip,
            this.toolStripSeparator4,
            this.btDrawPixel,
            this.btDrawLine,
            this.btDrawRect,
            this.btDrawFilledRect});
            this.myToolbar.Location = new System.Drawing.Point(0, 24);
            this.myToolbar.Name = "myToolbar";
            this.myToolbar.Size = new System.Drawing.Size(1006, 27);
            this.myToolbar.TabIndex = 1;
            this.myToolbar.Text = "toolStrip1";
            this.myToolbar.Visible = global::AAStudio.Properties.Settings.Default.ToolbarVisible;
            // 
            // btNew
            // 
            this.btNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNew.Image = global::AAStudio.Properties.Resources.ic_palette_black_18dp_1x;
            this.btNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(24, 24);
            this.btNew.Text = "New [Ctrl+N]";
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btOpen
            // 
            this.btOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btOpen.Image = global::AAStudio.Properties.Resources.ic_file_upload_black_18dp_1x;
            this.btOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(24, 24);
            this.btOpen.Text = "Open [Ctrl+O]";
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btSave.Image = global::AAStudio.Properties.Resources.ic_file_download_black_18dp_1x;
            this.btSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(24, 24);
            this.btSave.Text = "Save [Ctrl+S]";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btAddSprite
            // 
            this.btAddSprite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btAddSprite.Image = global::AAStudio.Properties.Resources.ic_add_circle_outline_black_18dp_1x;
            this.btAddSprite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAddSprite.Name = "btAddSprite";
            this.btAddSprite.Size = new System.Drawing.Size(24, 24);
            this.btAddSprite.Text = "Add sprite [Ctrl+Ins]";
            this.btAddSprite.Click += new System.EventHandler(this.btAddSprite_Click);
            // 
            // btDeleteSprite
            // 
            this.btDeleteSprite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDeleteSprite.Image = global::AAStudio.Properties.Resources.ic_remove_circle_outline_black_18dp_1x;
            this.btDeleteSprite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDeleteSprite.Name = "btDeleteSprite";
            this.btDeleteSprite.Size = new System.Drawing.Size(24, 24);
            this.btDeleteSprite.Text = "Delete sprite [Ctrl+Del]";
            this.btDeleteSprite.Click += new System.EventHandler(this.btDeleteSprite_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btShowGrid
            // 
            this.btShowGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btShowGrid.Image = global::AAStudio.Properties.Resources.ic_grid_on_black_18dp_1x;
            this.btShowGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btShowGrid.Name = "btShowGrid";
            this.btShowGrid.Size = new System.Drawing.Size(24, 24);
            this.btShowGrid.Text = "Show grid [Ctrl+G]";
            this.btShowGrid.Click += new System.EventHandler(this.btShowGrid_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // btNone
            // 
            this.btNone.CheckOnClick = true;
            this.btNone.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btNone.Image = global::AAStudio.Properties.Resources.ic_visibility_black_18dp_1x;
            this.btNone.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btNone.Name = "btNone";
            this.btNone.Size = new System.Drawing.Size(24, 24);
            this.btNone.Text = "None";
            this.btNone.Click += new System.EventHandler(this.btNone_Click);
            // 
            // btDoSelect
            // 
            this.btDoSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDoSelect.Image = global::AAStudio.Properties.Resources.ic_photo_size_select_small_black_18dp_1x;
            this.btDoSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDoSelect.Name = "btDoSelect";
            this.btDoSelect.Size = new System.Drawing.Size(24, 24);
            this.btDoSelect.Text = "Select";
            this.btDoSelect.Click += new System.EventHandler(this.btDoSelect_Click);
            // 
            // btDoMove
            // 
            this.btDoMove.CheckOnClick = true;
            this.btDoMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDoMove.Image = global::AAStudio.Properties.Resources.ic_open_with_black_18dp_1x;
            this.btDoMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDoMove.Name = "btDoMove";
            this.btDoMove.Size = new System.Drawing.Size(24, 24);
            this.btDoMove.Text = "Move selection";
            this.btDoMove.Click += new System.EventHandler(this.btToolMove_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // btDoCopy
            // 
            this.btDoCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDoCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btDoCopySprite,
            this.btDoCopyProject});
            this.btDoCopy.Image = global::AAStudio.Properties.Resources.ic_content_copy_black_18dp_1x;
            this.btDoCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDoCopy.Name = "btDoCopy";
            this.btDoCopy.Size = new System.Drawing.Size(33, 24);
            this.btDoCopy.Text = "Copy to clipboard...";
            // 
            // btDoCopySprite
            // 
            this.btDoCopySprite.Name = "btDoCopySprite";
            this.btDoCopySprite.Size = new System.Drawing.Size(148, 22);
            this.btDoCopySprite.Text = "Current sprite";
            this.btDoCopySprite.Click += new System.EventHandler(this.btDoCopySprite_Click);
            // 
            // btDoCopyProject
            // 
            this.btDoCopyProject.Name = "btDoCopyProject";
            this.btDoCopyProject.Size = new System.Drawing.Size(148, 22);
            this.btDoCopyProject.Text = "Whole project";
            this.btDoCopyProject.Click += new System.EventHandler(this.btDoCopyProject_Click);
            // 
            // btDoDuplicate
            // 
            this.btDoDuplicate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDoDuplicate.Image = global::AAStudio.Properties.Resources.ic_content_paste_black_18dp_1x;
            this.btDoDuplicate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDoDuplicate.Name = "btDoDuplicate";
            this.btDoDuplicate.Size = new System.Drawing.Size(24, 24);
            this.btDoDuplicate.Text = "Duplicate sprite [Ctrl+D]";
            this.btDoDuplicate.Click += new System.EventHandler(this.btDoDuplicate_Click);
            // 
            // btDoVideoInvert
            // 
            this.btDoVideoInvert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDoVideoInvert.Image = global::AAStudio.Properties.Resources.ic_compare_black_18dp_1x;
            this.btDoVideoInvert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDoVideoInvert.Name = "btDoVideoInvert";
            this.btDoVideoInvert.Size = new System.Drawing.Size(24, 24);
            this.btDoVideoInvert.Text = "Video Invert [Shift+Ctrl+I]";
            this.btDoVideoInvert.Click += new System.EventHandler(this.btDoVideoInvert_Click);
            // 
            // btDoFlip
            // 
            this.btDoFlip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDoFlip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btDoFlipHorizontal,
            this.btDoFlipVertical});
            this.btDoFlip.Image = global::AAStudio.Properties.Resources.ic_flip_black_18dp_1x;
            this.btDoFlip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDoFlip.Name = "btDoFlip";
            this.btDoFlip.Size = new System.Drawing.Size(33, 24);
            this.btDoFlip.Text = "Flip...";
            // 
            // btDoFlipHorizontal
            // 
            this.btDoFlipHorizontal.Name = "btDoFlipHorizontal";
            this.btDoFlipHorizontal.Size = new System.Drawing.Size(129, 22);
            this.btDoFlipHorizontal.Text = "Horizontal";
            this.btDoFlipHorizontal.Click += new System.EventHandler(this.btDoFlipHorizontal_Click);
            // 
            // btDoFlipVertical
            // 
            this.btDoFlipVertical.Name = "btDoFlipVertical";
            this.btDoFlipVertical.Size = new System.Drawing.Size(129, 22);
            this.btDoFlipVertical.Text = "Vertical";
            this.btDoFlipVertical.Click += new System.EventHandler(this.btDoFlipVertical_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // btDrawPixel
            // 
            this.btDrawPixel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDrawPixel.Image = global::AAStudio.Properties.Resources.ic_mode_edit_black_18dp_1x;
            this.btDrawPixel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDrawPixel.Name = "btDrawPixel";
            this.btDrawPixel.Size = new System.Drawing.Size(24, 24);
            this.btDrawPixel.Text = "Draw pixels [Ctrl+P]";
            this.btDrawPixel.Click += new System.EventHandler(this.btDrawPixel_Click);
            // 
            // btDrawLine
            // 
            this.btDrawLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDrawLine.Image = global::AAStudio.Properties.Resources.ic_border_color_black_18dp_1x;
            this.btDrawLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDrawLine.Name = "btDrawLine";
            this.btDrawLine.Size = new System.Drawing.Size(24, 24);
            this.btDrawLine.Text = "Draw line [Ctrl+L]";
            this.btDrawLine.Click += new System.EventHandler(this.btDrawLine_Click);
            // 
            // btDrawRect
            // 
            this.btDrawRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDrawRect.Image = global::AAStudio.Properties.Resources.draw_rect;
            this.btDrawRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDrawRect.Name = "btDrawRect";
            this.btDrawRect.Size = new System.Drawing.Size(24, 24);
            this.btDrawRect.Text = "Rectangle [Ctrl+R]";
            this.btDrawRect.Click += new System.EventHandler(this.btDrawRect_Click);
            // 
            // btDrawFilledRect
            // 
            this.btDrawFilledRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btDrawFilledRect.Image = global::AAStudio.Properties.Resources.fill_rect;
            this.btDrawFilledRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDrawFilledRect.Name = "btDrawFilledRect";
            this.btDrawFilledRect.Size = new System.Drawing.Size(24, 24);
            this.btDrawFilledRect.Text = "Filled rectangle [Ctrl+Shift+R]";
            this.btDrawFilledRect.Click += new System.EventHandler(this.btDrawFilledRect_Click);
            // 
            // myOpenDialog
            // 
            this.myOpenDialog.DefaultExt = "aasf";
            this.myOpenDialog.Filter = "ARDUBOY Art Studio files (*.aasf)|*.aasf|All files (*.*)|*.*";
            this.myOpenDialog.Title = "Open an ARDUBOY art file";
            // 
            // mySaveDialog
            // 
            this.mySaveDialog.DefaultExt = "aasf";
            this.mySaveDialog.Filter = "ARDUBOY Art Studio files (*.aasf)|*.aasf|All files (*.*)|*.*";
            this.mySaveDialog.Title = "Save the ARDUBOY art file";
            // 
            // paneInformation
            // 
            this.paneInformation.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneInformation.Location = new System.Drawing.Point(731, 51);
            this.paneInformation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneInformation.Name = "paneInformation";
            this.paneInformation.Size = new System.Drawing.Size(275, 495);
            this.paneInformation.Sprite = null;
            this.paneInformation.TabIndex = 25;
            // 
            // splitterRight
            // 
            this.splitterRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterRight.Enabled = false;
            this.splitterRight.Location = new System.Drawing.Point(728, 51);
            this.splitterRight.Name = "splitterRight";
            this.splitterRight.Size = new System.Drawing.Size(3, 495);
            this.splitterRight.TabIndex = 26;
            this.splitterRight.TabStop = false;
            // 
            // paneContent
            // 
            this.paneContent.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneContent.CurrentTool = AAStudio.DrawingTools.None;
            this.paneContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneContent.Location = new System.Drawing.Point(223, 51);
            this.paneContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.paneContent.Name = "paneContent";
            this.paneContent.ShowGrid = false;
            this.paneContent.Size = new System.Drawing.Size(505, 495);
            this.paneContent.Sprite = null;
            this.paneContent.TabIndex = 27;
            this.paneContent.OnMouseMoved += new AAStudio.MouseMovedHandler(this.paneContent_OnMouseMoved);
            this.paneContent.OnNotify += new AAStudio.NotifyHandler(this.paneContent_OnNotify);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.paneContent);
            this.Controls.Add(this.splitterRight);
            this.Controls.Add(this.paneInformation);
            this.Controls.Add(this.splitterLeft);
            this.Controls.Add(this.paneExplorer);
            this.Controls.Add(this.splitterBottom);
            this.Controls.Add(this.paneDebug);
            this.Controls.Add(this.myStatusbar);
            this.Controls.Add(this.myToolbar);
            this.Controls.Add(this.myMenu);
            this.MainMenuStrip = this.myMenu;
            this.Name = "MainForm";
            this.Text = "ARDUBOY Art Studio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.myMenu.ResumeLayout(false);
            this.myMenu.PerformLayout();
            this.myStatusbar.ResumeLayout(false);
            this.myStatusbar.PerformLayout();
            this.myToolbar.ResumeLayout(false);
            this.myToolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip myMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStrip myToolbar;
        private System.Windows.Forms.StatusStrip myStatusbar;
        private DebugSidebar paneDebug;
        private System.Windows.Forms.Splitter splitterBottom;
        private ExplorerSidebar paneExplorer;
        private System.Windows.Forms.Splitter splitterLeft;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuQuit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolbar;
        private System.Windows.Forms.ToolStripMenuItem menuStatusbar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuPaneDebug;
        private System.Windows.Forms.ToolStripMenuItem menuPaneExplorer;
        private System.Windows.Forms.ToolStripMenuItem menuPaneInformation;
        private System.Windows.Forms.OpenFileDialog myOpenDialog;
        private System.Windows.Forms.SaveFileDialog mySaveDialog;
        private System.Windows.Forms.ToolStripButton btNew;
        private System.Windows.Forms.ToolStripButton btOpen;
        private System.Windows.Forms.ToolStripButton btSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAddSprite;
        private System.Windows.Forms.ToolStripMenuItem menuDeleteSprite;
        private System.Windows.Forms.ToolStripButton btAddSprite;
        private System.Windows.Forms.ToolStripButton btDeleteSprite;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem menuShowGrid;
        private System.Windows.Forms.ToolStripButton btShowGrid;
        private System.Windows.Forms.ToolStripStatusLabel myMouse;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btNone;
        private System.Windows.Forms.ToolStripMenuItem menuDoMove;
        private System.Windows.Forms.ToolStripButton btDoMove;
        private System.Windows.Forms.ToolStripButton btDoSelect;
        private System.Windows.Forms.ToolStripMenuItem menuDoSelect;
        private System.Windows.Forms.ToolStripButton btDrawPixel;
        private System.Windows.Forms.ToolStripButton btDrawLine;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem menuDrawPixel;
        private System.Windows.Forms.ToolStripMenuItem menuDrawLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuDoCopy;
        private System.Windows.Forms.ToolStripMenuItem menuDoCopySprite;
        private System.Windows.Forms.ToolStripDropDownButton btDoCopy;
        private System.Windows.Forms.ToolStripMenuItem btDoCopySprite;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem menuDoCopyProject;
        private System.Windows.Forms.ToolStripMenuItem btDoCopyProject;
        private InformationSidebar paneInformation;
        private System.Windows.Forms.Splitter splitterRight;
        private DrawingArea paneContent;
        private System.Windows.Forms.ToolStripMenuItem menuDoVideoInvert;
        private System.Windows.Forms.ToolStripButton btDoVideoInvert;
        private System.Windows.Forms.ToolStripButton btDrawRect;
        private System.Windows.Forms.ToolStripButton btDrawFilledRect;
        private System.Windows.Forms.ToolStripMenuItem menuDrawRect;
        private System.Windows.Forms.ToolStripMenuItem menuDrawFilledRect;
        private System.Windows.Forms.ToolStripMenuItem menuDoDuplicate;
        private System.Windows.Forms.ToolStripButton btDoDuplicate;
        private System.Windows.Forms.ToolStripMenuItem menuDoFlip;
        private System.Windows.Forms.ToolStripMenuItem menuDoFlipHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuDoFlipVertical;
        private System.Windows.Forms.ToolStripDropDownButton btDoFlip;
        private System.Windows.Forms.ToolStripMenuItem btDoFlipHorizontal;
        private System.Windows.Forms.ToolStripMenuItem btDoFlipVertical;
        private System.Windows.Forms.ToolStripMenuItem menuImport;
    }
}

