namespace Paint.UI
{
    partial class CloudSave
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
            this.btnAmazonCloud = new System.Windows.Forms.Button();
            this.btnGoogleCloud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAmazonCloud
            // 
            this.btnAmazonCloud.Location = new System.Drawing.Point(259, 85);
            this.btnAmazonCloud.Name = "btnAmazonCloud";
            this.btnAmazonCloud.Size = new System.Drawing.Size(130, 61);
            this.btnAmazonCloud.TabIndex = 5;
            this.btnAmazonCloud.Text = "Amazon Cloud";
            this.btnAmazonCloud.UseVisualStyleBackColor = true;
            // 
            // btnGoogleCloud
            // 
            this.btnGoogleCloud.Location = new System.Drawing.Point(82, 85);
            this.btnGoogleCloud.Name = "btnGoogleCloud";
            this.btnGoogleCloud.Size = new System.Drawing.Size(129, 61);
            this.btnGoogleCloud.TabIndex = 4;
            this.btnGoogleCloud.Text = "Google Cloud";
            this.btnGoogleCloud.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select cloud:";
            // 
            // CloudSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 187);
            this.Controls.Add(this.btnAmazonCloud);
            this.Controls.Add(this.btnGoogleCloud);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloudSave";
            this.ShowIcon = false;
            this.Text = "Save in CLoud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAmazonCloud;
        private System.Windows.Forms.Button btnGoogleCloud;
        private System.Windows.Forms.Label label1;
    }
}