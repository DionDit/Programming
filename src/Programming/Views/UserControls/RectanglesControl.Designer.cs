namespace Programming.Views.UserControls
{
    partial class RectanglesControl
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
            this.label16 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LenghtTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(207, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(207, 25);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(131, 20);
            this.IdTextBox.TabIndex = 28;
            this.IdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputData);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 182);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 26);
            this.label15.TabIndex = 27;
            this.label15.Text = "Coordinates\r\nrectangle center";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(207, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Y:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(207, 270);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(131, 20);
            this.YTextBox.TabIndex = 25;
            this.YTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputData);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(207, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "X:";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(207, 225);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(131, 20);
            this.XTextBox.TabIndex = 23;
            this.XTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputData);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(207, 312);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(131, 23);
            this.FindButton.TabIndex = 22;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Color:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(207, 157);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(131, 20);
            this.ColorTextBox.TabIndex = 20;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Width:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(207, 112);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(131, 20);
            this.WidthTextBox.TabIndex = 18;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Lenght:";
            // 
            // LenghtTextBox
            // 
            this.LenghtTextBox.Location = new System.Drawing.Point(207, 64);
            this.LenghtTextBox.Name = "LenghtTextBox";
            this.LenghtTextBox.Size = new System.Drawing.Size(131, 20);
            this.LenghtTextBox.TabIndex = 16;
            this.LenghtTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // RectanglesBox
            // 
            this.RectanglesBox.FormattingEnabled = true;
            this.RectanglesBox.Location = new System.Drawing.Point(3, 6);
            this.RectanglesBox.Name = "RectanglesBox";
            this.RectanglesBox.Size = new System.Drawing.Size(198, 368);
            this.RectanglesBox.TabIndex = 15;
            this.RectanglesBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LenghtTextBox);
            this.Controls.Add(this.RectanglesBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(340, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LenghtTextBox;
        private System.Windows.Forms.ListBox RectanglesBox;
    }
}
