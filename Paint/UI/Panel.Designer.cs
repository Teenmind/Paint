namespace Paint.UI
{
    partial class Panel
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
            this.statusBar1 = new Paint.UI.StatusBar();
            this.toolBar1 = new Paint.UI.ToolBar();
            this.menu1 = new Paint.Menu();
            this.plugins1 = new Paint.UI.Plugins();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(2, 497);
            this.statusBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(824, 27);
            this.statusBar1.TabIndex = 2;
            // 
            // toolBar1
            // 
            this.toolBar1.Location = new System.Drawing.Point(0, 23);
            this.toolBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(808, 23);
            this.toolBar1.TabIndex = 1;
            // 
            // menu1
            // 
            this.menu1.Location = new System.Drawing.Point(0, 0);
            this.menu1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(808, 25);
            this.menu1.TabIndex = 0;
            // 
            // plugins1
            // 
            this.plugins1.Location = new System.Drawing.Point(0, 85);
            this.plugins1.Margin = new System.Windows.Forms.Padding(2);
            this.plugins1.Name = "plugins1";
            this.plugins1.Size = new System.Drawing.Size(181, 408);
            this.plugins1.TabIndex = 3;
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plugins1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.menu1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Panel";
            this.Size = new System.Drawing.Size(824, 524);
            this.ResumeLayout(false);

        }

        #endregion

        private Menu menu1;
        private ToolBar toolBar1;
        private StatusBar statusBar1;
        private Plugins plugins1;
    }
}
