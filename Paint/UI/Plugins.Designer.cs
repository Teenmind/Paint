namespace Paint.UI
{
    partial class Plugins
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
            this.groupBoxPlugins = new System.Windows.Forms.GroupBox();
            this.btnFigureImage = new System.Windows.Forms.Button();
            this.btnFigureText = new System.Windows.Forms.Button();
            this.btnEmptyFigure = new System.Windows.Forms.Button();
            this.groupBoxPlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPlugins
            // 
            this.groupBoxPlugins.Controls.Add(this.btnFigureImage);
            this.groupBoxPlugins.Controls.Add(this.btnFigureText);
            this.groupBoxPlugins.Controls.Add(this.btnEmptyFigure);
            this.groupBoxPlugins.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPlugins.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPlugins.Name = "groupBoxPlugins";
            this.groupBoxPlugins.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPlugins.Size = new System.Drawing.Size(175, 361);
            this.groupBoxPlugins.TabIndex = 0;
            this.groupBoxPlugins.TabStop = false;
            this.groupBoxPlugins.Text = "Plugins";
            // 
            // btnFigureImage
            // 
            this.btnFigureImage.Location = new System.Drawing.Point(40, 191);
            this.btnFigureImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnFigureImage.Name = "btnFigureImage";
            this.btnFigureImage.Size = new System.Drawing.Size(100, 31);
            this.btnFigureImage.TabIndex = 3;
            this.btnFigureImage.Text = "Figure with image";
            this.btnFigureImage.UseVisualStyleBackColor = true;
            // 
            // btnFigureText
            // 
            this.btnFigureText.Location = new System.Drawing.Point(40, 149);
            this.btnFigureText.Margin = new System.Windows.Forms.Padding(2);
            this.btnFigureText.Name = "btnFigureText";
            this.btnFigureText.Size = new System.Drawing.Size(100, 28);
            this.btnFigureText.TabIndex = 2;
            this.btnFigureText.Text = "Figure with text";
            this.btnFigureText.UseVisualStyleBackColor = true;
            // 
            // btnEmptyFigure
            // 
            this.btnEmptyFigure.Location = new System.Drawing.Point(40, 105);
            this.btnEmptyFigure.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmptyFigure.Name = "btnEmptyFigure";
            this.btnEmptyFigure.Size = new System.Drawing.Size(100, 28);
            this.btnEmptyFigure.TabIndex = 1;
            this.btnEmptyFigure.Text = "Empty figure";
            this.btnEmptyFigure.UseVisualStyleBackColor = true;
            // 
            // Plugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPlugins);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Plugins";
            this.Size = new System.Drawing.Size(181, 345);
            this.groupBoxPlugins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPlugins;
        private System.Windows.Forms.Button btnFigureImage;
        private System.Windows.Forms.Button btnFigureText;
        private System.Windows.Forms.Button btnEmptyFigure;
    }
}
