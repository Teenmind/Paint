namespace Paint.UI
{
    partial class StatusBar
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
            this.toolStripStatusBar = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripStatusBar
            // 
            this.toolStripStatusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripStatusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStripStatusBar.Location = new System.Drawing.Point(416, 6);
            this.toolStripStatusBar.Name = "toolStripStatusBar";
            this.toolStripStatusBar.Size = new System.Drawing.Size(91, 25);
            this.toolStripStatusBar.TabIndex = 0;
            this.toolStripStatusBar.Text = "toolStripStatusBar";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Enabled = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.toolStripLabel1.Text = "x: 0, y: 0";
            // 
            // StatusBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripStatusBar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StatusBar";
            this.Size = new System.Drawing.Size(830, 31);
            this.toolStripStatusBar.ResumeLayout(false);
            this.toolStripStatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripStatusBar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}
