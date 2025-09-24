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
            FullNameTextBox = new TextBox();
            label4 = new Label();
            IdTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            AddRandomBtn = new Button();
            RemoveBtn = new Button();
            AddBtn = new Button();
            CustomerListBox = new ListBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            panel1 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(79, 78);
            FullNameTextBox.Margin = new Padding(3, 8, 3, 3);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(398, 23);
            FullNameTextBox.TabIndex = 8;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 70);
            label4.Name = "label4";
            label4.Size = new Size(64, 39);
            label4.TabIndex = 7;
            label4.Text = "Full Name:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            IdTextBox.Location = new Point(79, 39);
            IdTextBox.Margin = new Padding(3, 8, 3, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(150, 23);
            IdTextBox.TabIndex = 6;
            IdTextBox.KeyPress += InputData;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 31);
            label3.Name = "label3";
            label3.Size = new Size(21, 39);
            label3.TabIndex = 5;
            label3.Text = "ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            tableLayoutPanel4.SetColumnSpan(label2, 2);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 31);
            label2.TabIndex = 4;
            label2.Text = "Selected Customer";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddRandomBtn
            // 
            AddRandomBtn.Dock = DockStyle.Fill;
            AddRandomBtn.Location = new Point(321, 3);
            AddRandomBtn.Name = "AddRandomBtn";
            AddRandomBtn.Size = new Size(156, 40);
            AddRandomBtn.TabIndex = 4;
            AddRandomBtn.Text = "Add Random";
            AddRandomBtn.UseVisualStyleBackColor = true;
            AddRandomBtn.Click += AddRandomBtn_Click;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Dock = DockStyle.Fill;
            RemoveBtn.Location = new Point(162, 3);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(153, 40);
            RemoveBtn.TabIndex = 3;
            RemoveBtn.Text = "Remove";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.Dock = DockStyle.Fill;
            AddBtn.Location = new Point(3, 3);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(153, 40);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // CustomerListBox
            // 
            CustomerListBox.Dock = DockStyle.Fill;
            CustomerListBox.FormattingEnabled = true;
            CustomerListBox.Location = new Point(3, 3);
            CustomerListBox.Name = "CustomerListBox";
            CustomerListBox.Size = new Size(480, 469);
            CustomerListBox.TabIndex = 1;
            CustomerListBox.SelectedIndexChanged += CustomerListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 28);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.102041F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 94.89796F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(984, 561);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(CustomerListBox, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 31);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 99.99999F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.Size = new Size(486, 527);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(AddRandomBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(AddBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(RemoveBtn, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 478);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(480, 46);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel5.Controls.Add(panel1, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(495, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel5, 2);
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 58.1981964F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 41.8018036F));
            tableLayoutPanel5.Size = new Size(486, 555);
            tableLayoutPanel5.TabIndex = 3;
            tableLayoutPanel5.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.833333F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.1666641F));
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 1);
            tableLayoutPanel4.Controls.Add(FullNameTextBox, 1, 2);
            tableLayoutPanel4.Controls.Add(IdTextBox, 1, 1);
            tableLayoutPanel4.Controls.Add(label4, 0, 2);
            tableLayoutPanel4.Controls.Add(addressControl1, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 10.3267756F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9583063F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9583063F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 34.5722466F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20.2764969F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5207376F));
            tableLayoutPanel4.Size = new Size(480, 316);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // addressControl1
            // 
            tableLayoutPanel4.SetColumnSpan(addressControl1, 2);
            addressControl1.Dock = DockStyle.Fill;
            addressControl1.Location = new Point(3, 112);
            addressControl1.Name = "addressControl1";
            tableLayoutPanel4.SetRowSpan(addressControl1, 3);
            addressControl1.Size = new Size(474, 201);
            addressControl1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 325);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 227);
            panel1.TabIndex = 7;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CustomersTab";
            Size = new Size(984, 561);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox FullNameTextBox;
        private Label label4;
        private TextBox IdTextBox;
        private Label label3;
        private Label label2;
        private Button RemoveBtn;
        private Button AddBtn;
        private ListBox CustomerListBox;
        private Label label1;
        private Button AddRandomBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel1;
        private Controls.AddressControl addressControl1;
    }
}
