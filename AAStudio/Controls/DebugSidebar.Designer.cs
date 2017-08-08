namespace AAStudio
{
    partial class DebugSidebar
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
            this.myMessage = new System.Windows.Forms.TextBox();
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
            this.myTitle.Size = new System.Drawing.Size(1013, 23);
            this.myTitle.TabIndex = 0;
            this.myTitle.Text = "Messages:";
            // 
            // myMessage
            // 
            this.myMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myMessage.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myMessage.Location = new System.Drawing.Point(0, 23);
            this.myMessage.Multiline = true;
            this.myMessage.Name = "myMessage";
            this.myMessage.ReadOnly = true;
            this.myMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.myMessage.Size = new System.Drawing.Size(1013, 127);
            this.myMessage.TabIndex = 1;
            // 
            // DebugSidebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myMessage);
            this.Controls.Add(this.myTitle);
            this.Name = "DebugSidebar";
            this.Size = new System.Drawing.Size(1013, 150);
            this.Load += new System.EventHandler(this.MessageControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myTitle;
        private System.Windows.Forms.TextBox myMessage;
    }
}
