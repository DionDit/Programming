namespace ObjectOrientedPractics.View.Dialogs
{
    partial class ItemsAddForm
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
            panel3 = new Panel();
            button1 = new Button();
            NameTextBox = new RichTextBox();
            label6 = new Label();
            DescriptionTextBox = new RichTextBox();
            label5 = new Label();
            CostTextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            CategoryComboBox = new ComboBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(CategoryComboBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(NameTextBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(DescriptionTextBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(CostTextBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 417);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(122, 368);
            button1.Name = "button1";
            button1.Size = new Size(123, 37);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(7, 140);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(338, 96);
            NameTextBox.TabIndex = 12;
            NameTextBox.Text = "";
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 122);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Name:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(7, 265);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(338, 96);
            DescriptionTextBox.TabIndex = 10;
            DescriptionTextBox.Text = "";
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 247);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 9;
            label5.Text = "Description:";
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(78, 59);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(148, 23);
            CostTextBox.TabIndex = 8;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 62);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Cost:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(124, 8);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 4;
            label2.Text = "Adding Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 91);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 16;
            label3.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(78, 91);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(148, 23);
            CategoryComboBox.TabIndex = 17;
            // 
            // ItemsAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 417);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ItemsAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adding Item";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private RichTextBox NameTextBox;
        private Label label6;
        private RichTextBox DescriptionTextBox;
        private Label label5;
        private TextBox CostTextBox;
        private Label label4;
        private Label label2;
        private Button button1;
        private ComboBox CategoryComboBox;
        private Label label3;
    }
}