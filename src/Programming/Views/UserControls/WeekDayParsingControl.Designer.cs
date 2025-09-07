namespace Programming.Views.UserControls
{
    partial class WeekDayParsingControl
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
            this.WeekDayParseButton = new System.Windows.Forms.Button();
            this.WeekDayTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WeekDayText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeekDayParseButton
            // 
            this.WeekDayParseButton.Location = new System.Drawing.Point(233, 26);
            this.WeekDayParseButton.Name = "WeekDayParseButton";
            this.WeekDayParseButton.Size = new System.Drawing.Size(126, 23);
            this.WeekDayParseButton.TabIndex = 5;
            this.WeekDayParseButton.Text = "Parse";
            this.WeekDayParseButton.UseVisualStyleBackColor = true;
            this.WeekDayParseButton.Click += new System.EventHandler(this.WeekDayParseButtonClick);
            // 
            // WeekDayTextBox
            // 
            this.WeekDayTextBox.Location = new System.Drawing.Point(15, 28);
            this.WeekDayTextBox.Name = "WeekDayTextBox";
            this.WeekDayTextBox.Size = new System.Drawing.Size(212, 20);
            this.WeekDayTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type value for parsing:";
            // 
            // WeekDayText
            // 
            this.WeekDayText.AutoSize = true;
            this.WeekDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeekDayText.ForeColor = System.Drawing.Color.Gray;
            this.WeekDayText.Location = new System.Drawing.Point(20, 61);
            this.WeekDayText.Name = "WeekDayText";
            this.WeekDayText.Size = new System.Drawing.Size(0, 17);
            this.WeekDayText.TabIndex = 6;
            // 
            // WeekDayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.WeekDayText);
            this.Controls.Add(this.WeekDayParseButton);
            this.Controls.Add(this.WeekDayTextBox);
            this.Controls.Add(this.label4);
            this.Name = "WeekDayParsingControl";
            this.Size = new System.Drawing.Size(372, 92);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WeekDayParseButton;
        private System.Windows.Forms.TextBox WeekDayTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label WeekDayText;
    }
}
