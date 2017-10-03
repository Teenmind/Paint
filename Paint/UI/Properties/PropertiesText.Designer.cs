namespace Paint.UI.Properties
{
    partial class PropertiesText
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxWidth = new System.Windows.Forms.ComboBox();
            this.Width = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnColorText = new System.Windows.Forms.Button();
            this.buttonSetText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Line",
            "Elipse",
            "Rectangle",
            "RoundRect",
            "",
            ""});
            this.comboBoxType.Location = new System.Drawing.Point(69, 92);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 9;
            // 
            // comboBoxWidth
            // 
            this.comboBoxWidth.FormattingEnabled = true;
            this.comboBoxWidth.Items.AddRange(new object[] {
            "1",
            "3",
            "5"});
            this.comboBoxWidth.Location = new System.Drawing.Point(69, 58);
            this.comboBoxWidth.Name = "comboBoxWidth";
            this.comboBoxWidth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWidth.TabIndex = 8;
            // 
            // Width
            // 
            this.Width.AutoSize = true;
            this.Width.Location = new System.Drawing.Point(25, 92);
            this.Width.Name = "Width";
            this.Width.Size = new System.Drawing.Size(34, 13);
            this.Width.TabIndex = 7;
            this.Width.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(18, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(99, 166);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(108, 20);
            this.textBoxText.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Angle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Align:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "0",
            "30",
            "45",
            "60",
            "90",
            "180"});
            this.comboBox2.Location = new System.Drawing.Point(59, 337);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 21);
            this.comboBox2.TabIndex = 27;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Top",
            "Bottom",
            "Left",
            "Right",
            "Center"});
            this.comboBox1.Location = new System.Drawing.Point(59, 300);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(18, 245);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(75, 23);
            this.btnFont.TabIndex = 25;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            // 
            // btnColorText
            // 
            this.btnColorText.Location = new System.Drawing.Point(18, 204);
            this.btnColorText.Name = "btnColorText";
            this.btnColorText.Size = new System.Drawing.Size(75, 23);
            this.btnColorText.TabIndex = 24;
            this.btnColorText.Text = "Color for text";
            this.btnColorText.UseVisualStyleBackColor = true;
            // 
            // buttonSetText
            // 
            this.buttonSetText.Location = new System.Drawing.Point(18, 164);
            this.buttonSetText.Name = "buttonSetText";
            this.buttonSetText.Size = new System.Drawing.Size(75, 23);
            this.buttonSetText.TabIndex = 23;
            this.buttonSetText.Text = "Set text";
            this.buttonSetText.UseVisualStyleBackColor = true;
            // 
            // PropertiesText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColorText);
            this.Controls.Add(this.buttonSetText);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxWidth);
            this.Controls.Add(this.Width);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColor);
            this.Name = "PropertiesText";
            this.Size = new System.Drawing.Size(222, 444);
            this.Load += new System.EventHandler(this.PropertiesText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxWidth;
        private System.Windows.Forms.Label Width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnColorText;
        private System.Windows.Forms.Button buttonSetText;
    }
}
