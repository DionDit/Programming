namespace Programming.Views.UserControls
{
    partial class EnumerationsControl
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
            this.EnumValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnumValue
            // 
            this.EnumValue.BackColor = System.Drawing.Color.White;
            this.EnumValue.Location = new System.Drawing.Point(353, 33);
            this.EnumValue.Name = "EnumValue";
            this.EnumValue.ReadOnly = true;
            this.EnumValue.Size = new System.Drawing.Size(100, 20);
            this.EnumValue.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Int value:";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(187, 33);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(139, 199);
            this.ValueListBox.TabIndex = 8;
            this.ValueListBox.SelectedValueChanged += new System.EventHandler(this.ValueListBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose value:";
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Items.AddRange(new object[] {
            "Color",
            "FormStudyStudent",
            "Genre",
            "Season",
            "SmartphoneManufacturers",
            "WeekDay"});
            this.EnumListBox.Location = new System.Drawing.Point(14, 33);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(139, 199);
            this.EnumListBox.TabIndex = 6;
            this.EnumListBox.SelectedValueChanged += new System.EventHandler(this.EnumListBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose enumaration:";
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.EnumValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValueListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnumListBox);
            this.Controls.Add(this.label1);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(464, 243);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EnumValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.Label label1;
    }
}
