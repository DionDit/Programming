namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            AddressTextBox = new RichTextBox();
            label6 = new Label();
            FullNameTextBox = new TextBox();
            label4 = new Label();
            IdTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            AddRandomBtn = new Button();
            RemoveBtn = new Button();
            AddBtn = new Button();
            CustomerListBox = new ListBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 527);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(496, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(471, 293);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(AddressTextBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(FullNameTextBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(IdTextBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(496, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(471, 225);
            panel3.TabIndex = 1;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(77, 93);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(268, 96);
            AddressTextBox.TabIndex = 12;
            AddressTextBox.Text = "";
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 96);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 11;
            label6.Text = "Address:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(77, 59);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(268, 23);
            FullNameTextBox.TabIndex = 8;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 62);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 7;
            label4.Text = "Full Name:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(77, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(148, 23);
            IdTextBox.TabIndex = 6;
            IdTextBox.KeyPress += InputData;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 33);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 5;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(7, 4);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 4;
            label2.Text = "Selected Customer";
            // 
            // panel2
            // 
            panel2.Controls.Add(AddRandomBtn);
            panel2.Controls.Add(RemoveBtn);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(CustomerListBox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(490, 524);
            panel2.TabIndex = 0;
            // 
            // AddRandomBtn
            // 
            AddRandomBtn.Location = new Point(225, 482);
            AddRandomBtn.Name = "AddRandomBtn";
            AddRandomBtn.Size = new Size(105, 34);
            AddRandomBtn.TabIndex = 4;
            AddRandomBtn.Text = "Add Random";
            AddRandomBtn.UseVisualStyleBackColor = true;
            AddRandomBtn.Click += AddRandomBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new Point(114, 483);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(105, 34);
            RemoveBtn.TabIndex = 3;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(3, 483);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(105, 34);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CustomerListBox
            // 
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.Location = new Point(3, 22);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(484, 454);
            CustomerListBox.TabIndex = 1;
            CustomerListBox.SelectedIndexChanged += CustomerListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CustomersTab";
            Size = new Size(970, 527);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private RichTextBox AddressTextBox;
        private Label label6;
        private TextBox FullNameTextBox;
        private Label label4;
        private TextBox IdTextBox;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button RemoveBtn;
        private Button AddBtn;
        private ListBox CustomerListBox;
        private Label label1;
        private Panel panel4;
        private Button AddRandomBtn;
    }
}
