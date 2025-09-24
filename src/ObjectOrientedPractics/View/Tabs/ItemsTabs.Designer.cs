namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTabs
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
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            AddRandomBtn = new Button();
            RemoveBtn = new Button();
            AddBtn = new Button();
            ItemBox = new ListBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            label7 = new Label();
            CategoryComboBox = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 84);
            label6.Margin = new Padding(3, 0, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 11;
            label6.Text = "Name:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 180);
            label5.Margin = new Padding(3, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 58);
            label5.TabIndex = 9;
            label5.Text = "Description:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 30);
            label4.Name = "label4";
            label4.Size = new Size(83, 27);
            label4.TabIndex = 7;
            label4.Text = "Cost:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 5;
            label3.Text = "ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(473, 16);
            label2.TabIndex = 4;
            label2.Text = "Selected Items";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddRandomBtn
            // 
            AddRandomBtn.Dock = DockStyle.Fill;
            AddRandomBtn.Location = new Point(321, 3);
            AddRandomBtn.Name = "AddRandomBtn";
            AddRandomBtn.Size = new Size(155, 41);
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
            RemoveBtn.Size = new Size(153, 41);
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
            AddBtn.Size = new Size(153, 41);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // ItemBox
            // 
            ItemBox.Dock = DockStyle.Fill;
            ItemBox.FormattingEnabled = true;
            ItemBox.Location = new Point(3, 22);
            ItemBox.Name = "ItemBox";
            ItemBox.Size = new Size(479, 449);
            ItemBox.TabIndex = 1;
            ItemBox.SelectedIndexChanged += ItemBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 0;
            label1.Text = "Items";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(ItemBox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.00843859F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 95.99156F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(970, 527);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(488, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel4, 3);
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 3.125F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 96.875F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(479, 521);
            tableLayoutPanel4.TabIndex = 4;
            tableLayoutPanel4.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.White;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.8160667F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.18393F));
            tableLayoutPanel3.Controls.Add(IdTextBox, 1, 0);
            tableLayoutPanel3.Controls.Add(label4, 0, 1);
            tableLayoutPanel3.Controls.Add(CostTextBox, 1, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(label6, 0, 3);
            tableLayoutPanel3.Controls.Add(NameTextBox, 1, 3);
            tableLayoutPanel3.Controls.Add(label5, 0, 5);
            tableLayoutPanel3.Controls.Add(DescriptionTextBox, 1, 5);
            tableLayoutPanel3.Controls.Add(label7, 0, 2);
            tableLayoutPanel3.Controls.Add(CategoryComboBox, 1, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 8;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.228049F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.608782F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.608782F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 4.6092186F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 15.03006F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 11.8236475F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 17.43487F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 34.86974F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(473, 499);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Left;
            IdTextBox.Location = new Point(92, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(113, 23);
            IdTextBox.TabIndex = 6;
            IdTextBox.KeyPress += InputData;
            // 
            // CostTextBox
            // 
            CostTextBox.Anchor = AnchorStyles.Left;
            CostTextBox.Location = new Point(92, 33);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(113, 23);
            CostTextBox.TabIndex = 8;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            tableLayoutPanel3.SetColumnSpan(NameTextBox, 2);
            NameTextBox.Dock = DockStyle.Fill;
            NameTextBox.Location = new Point(3, 109);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(467, 68);
            NameTextBox.TabIndex = 12;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // DescriptionTextBox
            // 
            tableLayoutPanel3.SetColumnSpan(DescriptionTextBox, 2);
            DescriptionTextBox.Dock = DockStyle.Fill;
            DescriptionTextBox.Location = new Point(7, 241);
            DescriptionTextBox.Margin = new Padding(7, 3, 3, 3);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(463, 79);
            DescriptionTextBox.TabIndex = 13;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 57);
            label7.Name = "label7";
            label7.Size = new Size(58, 27);
            label7.TabIndex = 14;
            label7.Text = "Category:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(92, 60);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(200, 23);
            CategoryComboBox.TabIndex = 15;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(AddRandomBtn, 2, 0);
            tableLayoutPanel2.Controls.Add(AddBtn, 0, 0);
            tableLayoutPanel2.Controls.Add(RemoveBtn, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 477);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(479, 47);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // ItemsTabs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "ItemsTabs";
            Size = new Size(970, 527);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button AddBtn;
        private ListBox ItemBox;
        private Button RemoveBtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button AddRandomBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox IdTextBox;
        private TextBox CostTextBox;
        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label7;
        private ComboBox CategoryComboBox;
    }
}
