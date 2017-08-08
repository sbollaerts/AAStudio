namespace AAStudio
{
    partial class InformationSidebar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myTitle = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.myProperty = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // myTitle
            // 
            this.myTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.myTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.myTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myTitle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.myTitle.Location = new System.Drawing.Point(0, 0);
            this.myTitle.Name = "myTitle";
            this.myTitle.Size = new System.Drawing.Size(275, 23);
            this.myTitle.TabIndex = 25;
            this.myTitle.Text = "Preview";
            this.myTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPreview
            // 
            this.picPreview.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPreview.Location = new System.Drawing.Point(0, 23);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(275, 165);
            this.picPreview.TabIndex = 26;
            this.picPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.picPreview_Paint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(0, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // myProperty
            // 
            this.myProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myProperty.HelpVisible = false;
            this.myProperty.LineColor = System.Drawing.SystemColors.ControlDark;
            this.myProperty.Location = new System.Drawing.Point(0, 211);
            this.myProperty.Name = "myProperty";
            this.myProperty.Size = new System.Drawing.Size(275, 389);
            this.myProperty.TabIndex = 28;
            this.myProperty.ToolbarVisible = false;
            // 
            // InformationSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myProperty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.myTitle);
            this.DoubleBuffered = true;
            this.Name = "InformationSidebar";
            this.Size = new System.Drawing.Size(275, 600);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label myTitle;
        private System.Windows.Forms.Panel picPreview;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PropertyGrid myProperty;
    }
}
