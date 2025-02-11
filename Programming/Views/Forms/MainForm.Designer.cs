namespace Programming.Views.Forms
{
    partial class MainForm
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
            this.MainFormTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Enumerations = new System.Windows.Forms.GroupBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnumValue = new System.Windows.Forms.TextBox();
            this.WeekDayParseBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WeekDayTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.WeekDayText = new System.Windows.Forms.Label();
            this.MainFormTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.WeekDayParseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTab
            // 
            this.MainFormTab.Controls.Add(this.tabPage1);
            this.MainFormTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormTab.Location = new System.Drawing.Point(0, 0);
            this.MainFormTab.Name = "MainFormTab";
            this.MainFormTab.SelectedIndex = 0;
            this.MainFormTab.Size = new System.Drawing.Size(800, 433);
            this.MainFormTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.WeekDayParseBox);
            this.tabPage1.Controls.Add(this.Enumerations);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.EnumListBox.Location = new System.Drawing.Point(19, 42);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(139, 199);
            this.EnumListBox.TabIndex = 0;
            this.EnumListBox.SelectedValueChanged += new System.EventHandler(this.EnumListBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose enumaration:";
            // 
            // Enumerations
            // 
            this.Enumerations.Controls.Add(this.EnumValue);
            this.Enumerations.Controls.Add(this.label3);
            this.Enumerations.Controls.Add(this.ValueListBox);
            this.Enumerations.Controls.Add(this.label2);
            this.Enumerations.Controls.Add(this.EnumListBox);
            this.Enumerations.Controls.Add(this.label1);
            this.Enumerations.Location = new System.Drawing.Point(8, 6);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Size = new System.Drawing.Size(776, 262);
            this.Enumerations.TabIndex = 2;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(192, 42);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(139, 199);
            this.ValueListBox.TabIndex = 2;
            this.ValueListBox.SelectedValueChanged += new System.EventHandler(this.ValueListBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Int value:";
            // 
            // EnumValue
            // 
            this.EnumValue.Location = new System.Drawing.Point(358, 42);
            this.EnumValue.Name = "EnumValue";
            this.EnumValue.Size = new System.Drawing.Size(100, 20);
            this.EnumValue.TabIndex = 5;
            // 
            // WeekDayParseBox
            // 
            this.WeekDayParseBox.Controls.Add(this.WeekDayText);
            this.WeekDayParseBox.Controls.Add(this.button1);
            this.WeekDayParseBox.Controls.Add(this.WeekDayTextBox);
            this.WeekDayParseBox.Controls.Add(this.label4);
            this.WeekDayParseBox.Location = new System.Drawing.Point(8, 274);
            this.WeekDayParseBox.Name = "WeekDayParseBox";
            this.WeekDayParseBox.Size = new System.Drawing.Size(344, 125);
            this.WeekDayParseBox.TabIndex = 3;
            this.WeekDayParseBox.TabStop = false;
            this.WeekDayParseBox.Text = "WeekDay Parsing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type value for parsing:";
            // 
            // WeekDayTextBox
            // 
            this.WeekDayTextBox.Location = new System.Drawing.Point(19, 50);
            this.WeekDayTextBox.Name = "WeekDayTextBox";
            this.WeekDayTextBox.Size = new System.Drawing.Size(212, 20);
            this.WeekDayTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Parse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WeekDayText
            // 
            this.WeekDayText.AutoSize = true;
            this.WeekDayText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeekDayText.ForeColor = System.Drawing.Color.Gray;
            this.WeekDayText.Location = new System.Drawing.Point(16, 84);
            this.WeekDayText.Name = "WeekDayText";
            this.WeekDayText.Size = new System.Drawing.Size(0, 17);
            this.WeekDayText.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.MainFormTab);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.MainFormTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.Enumerations.ResumeLayout(false);
            this.Enumerations.PerformLayout();
            this.WeekDayParseBox.ResumeLayout(false);
            this.WeekDayParseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainFormTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Enumerations;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnumValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox WeekDayParseBox;
        private System.Windows.Forms.Label WeekDayText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox WeekDayTextBox;
        private System.Windows.Forms.Label label4;
    }
}