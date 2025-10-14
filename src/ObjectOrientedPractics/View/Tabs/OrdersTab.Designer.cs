namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            CreatedTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            IdTextBox = new TextBox();
            label5 = new Label();
            StatusComboBox = new ComboBox();
            addressControl1 = new ObjectOrientedPractics.View.Controls.AddressControl();
            label6 = new Label();
            OrderItemsListBox = new ListBox();
            label7 = new Label();
            AmountLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            OrdersDataGridView = new DataGridView();
            label8 = new Label();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.41711235F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.5828857F));
            tableLayoutPanel1.Size = new Size(984, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(495, 0);
            label2.Name = "label2";
            label2.Size = new Size(486, 36);
            label2.TabIndex = 3;
            label2.Text = "Selected Order";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(486, 36);
            label1.TabIndex = 1;
            label1.Text = "Items";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.7530861F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.24691F));
            tableLayoutPanel2.Controls.Add(CreatedTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(IdTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(StatusComboBox, 1, 2);
            tableLayoutPanel2.Controls.Add(addressControl1, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 8);
            tableLayoutPanel2.Controls.Add(OrderItemsListBox, 0, 9);
            tableLayoutPanel2.Controls.Add(label7, 1, 11);
            tableLayoutPanel2.Controls.Add(AmountLabel, 1, 12);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(495, 39);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.973025F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.39499044F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.58766842F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.4874763F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.3121388F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.009634F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7996149F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.Size = new Size(486, 519);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(99, 34);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(200, 23);
            CreatedTextBox.TabIndex = 4;
            CreatedTextBox.KeyPress += InputData;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 31);
            label4.Name = "label4";
            label4.Size = new Size(90, 28);
            label4.TabIndex = 2;
            label4.Text = "Created:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 31);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(99, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(200, 23);
            IdTextBox.TabIndex = 1;
            IdTextBox.KeyPress += InputData;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 59);
            label5.Name = "label5";
            label5.Size = new Size(90, 29);
            label5.TabIndex = 3;
            label5.Text = "Status:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(99, 62);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(200, 23);
            StatusComboBox.TabIndex = 5;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // addressControl1
            // 
            tableLayoutPanel2.SetColumnSpan(addressControl1, 2);
            addressControl1.Dock = DockStyle.Fill;
            addressControl1.Location = new Point(3, 91);
            addressControl1.Name = "addressControl1";
            tableLayoutPanel2.SetRowSpan(addressControl1, 5);
            addressControl1.Size = new Size(480, 196);
            addressControl1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(3, 290);
            label6.Name = "label6";
            label6.Size = new Size(90, 26);
            label6.TabIndex = 7;
            label6.Text = "Order Items";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OrderItemsListBox
            // 
            tableLayoutPanel2.SetColumnSpan(OrderItemsListBox, 2);
            OrderItemsListBox.Dock = DockStyle.Fill;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.Location = new Point(3, 319);
            OrderItemsListBox.Name = "OrderItemsListBox";
            tableLayoutPanel2.SetRowSpan(OrderItemsListBox, 2);
            OrderItemsListBox.Size = new Size(480, 116);
            OrderItemsListBox.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(99, 438);
            label7.Name = "label7";
            label7.Size = new Size(384, 40);
            label7.TabIndex = 9;
            label7.Text = "Amount:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Dock = DockStyle.Fill;
            AmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AmountLabel.Location = new Point(99, 478);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(384, 41);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "4 999,00 ₽";
            AmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.259259F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90.74074F));
            tableLayoutPanel3.Controls.Add(OrdersDataGridView, 0, 0);
            tableLayoutPanel3.Controls.Add(label8, 0, 1);
            tableLayoutPanel3.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 39);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 94.60501F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5.39499044F));
            tableLayoutPanel3.Size = new Size(486, 519);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel3.SetColumnSpan(OrdersDataGridView, 2);
            OrdersDataGridView.Dock = DockStyle.Fill;
            OrdersDataGridView.Location = new Point(3, 3);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.Size = new Size(480, 485);
            OrdersDataGridView.TabIndex = 2;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 491);
            label8.Name = "label8";
            label8.Size = new Size(39, 28);
            label8.TabIndex = 3;
            label8.Text = "Find:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 494);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrdersTab";
            Size = new Size(984, 561);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private DataGridView OrdersDataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox CreatedTextBox;
        private Label label4;
        private Label label3;
        private TextBox IdTextBox;
        private Label label5;
        private ComboBox StatusComboBox;
        private Controls.AddressControl addressControl1;
        private Label label6;
        private ListBox OrderItemsListBox;
        private Label label7;
        private Label AmountLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label8;
        private TextBox textBox1;
    }
}
