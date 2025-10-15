
namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            label10 = new Label();
            DeliveryTimeComboBox = new ComboBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            AddItemBtn = new Button();
            RemoveItemBtn = new Button();
            button3 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label9 = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(99, 38);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(145, 23);
            CreatedTextBox.TabIndex = 4;
            CreatedTextBox.KeyPress += InputData;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 35);
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
            label3.Size = new Size(89, 29);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(98, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(143, 23);
            IdTextBox.TabIndex = 1;
            IdTextBox.KeyPress += InputData;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 63);
            label5.Name = "label5";
            label5.Size = new Size(90, 30);
            label5.TabIndex = 3;
            label5.Text = "Status:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(99, 66);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(145, 23);
            StatusComboBox.TabIndex = 5;
            // 
            // addressControl1
            // 
            tableLayoutPanel2.SetColumnSpan(addressControl1, 2);
            addressControl1.Dock = DockStyle.Fill;
            addressControl1.Location = new Point(3, 96);
            addressControl1.Name = "addressControl1";
            tableLayoutPanel2.SetRowSpan(addressControl1, 5);
            addressControl1.Size = new Size(484, 178);
            addressControl1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(3, 277);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 7;
            label6.Text = "Order Items";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OrderItemsListBox
            // 
            tableLayoutPanel2.SetColumnSpan(OrderItemsListBox, 2);
            OrderItemsListBox.Dock = DockStyle.Fill;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.Location = new Point(3, 300);
            OrderItemsListBox.Name = "OrderItemsListBox";
            tableLayoutPanel2.SetRowSpan(OrderItemsListBox, 2);
            OrderItemsListBox.Size = new Size(484, 107);
            OrderItemsListBox.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(343, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 34);
            label7.TabIndex = 9;
            label7.Text = "Amount:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Dock = DockStyle.Fill;
            AmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AmountLabel.Location = new Point(343, 34);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(138, 34);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "4 999,00 ₽";
            AmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(239, 30);
            label2.TabIndex = 3;
            label2.Text = "Selected Order";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.7530861F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.24691F));
            tableLayoutPanel2.Controls.Add(CreatedTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(StatusComboBox, 1, 2);
            tableLayoutPanel2.Controls.Add(addressControl1, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 8);
            tableLayoutPanel2.Controls.Add(OrderItemsListBox, 0, 9);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 11);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(7, 39);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 13;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 6.743738F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.39499044F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.780347F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.285164F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230747F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.62427759F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 3.8535645F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6435452F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.1290946F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 2.11946058F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3044319F));
            tableLayoutPanel2.Size = new Size(490, 519);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel5, 2);
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.791666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.041666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.75F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.416666F));
            tableLayoutPanel5.Controls.Add(label10, 2, 0);
            tableLayoutPanel5.Controls.Add(label3, 0, 0);
            tableLayoutPanel5.Controls.Add(IdTextBox, 1, 0);
            tableLayoutPanel5.Controls.Add(DeliveryTimeComboBox, 3, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(484, 29);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(248, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 29);
            label10.TabIndex = 2;
            label10.Text = "Delivery Time:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.Dock = DockStyle.Fill;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Items.AddRange(new object[] { "9:00 – 11:00", "11:00 – 13:00", "13:00 – 15:00", "15:00 – 17:00", "17:00 – 19:00", "19:00 – 21:00" });
            DeliveryTimeComboBox.Location = new Point(338, 3);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(143, 23);
            DeliveryTimeComboBox.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel6, 2);
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.958334F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.75F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.083333F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.625F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.375F));
            tableLayoutPanel6.Controls.Add(AmountLabel, 4, 1);
            tableLayoutPanel6.Controls.Add(label7, 4, 0);
            tableLayoutPanel6.Controls.Add(AddItemBtn, 0, 2);
            tableLayoutPanel6.Controls.Add(RemoveItemBtn, 1, 2);
            tableLayoutPanel6.Controls.Add(button3, 4, 2);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 413);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 3;
            tableLayoutPanel2.SetRowSpan(tableLayoutPanel6, 2);
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel6.Size = new Size(484, 103);
            tableLayoutPanel6.TabIndex = 12;
            // 
            // AddItemBtn
            // 
            AddItemBtn.Dock = DockStyle.Fill;
            AddItemBtn.Location = new Point(3, 71);
            AddItemBtn.Name = "AddItemBtn";
            AddItemBtn.Size = new Size(110, 29);
            AddItemBtn.TabIndex = 11;
            AddItemBtn.Text = "Add Item";
            AddItemBtn.UseVisualStyleBackColor = true;
            AddItemBtn.Click += AddItemBtn_Click;
            // 
            // RemoveItemBtn
            // 
            RemoveItemBtn.Dock = DockStyle.Fill;
            RemoveItemBtn.Location = new Point(119, 71);
            RemoveItemBtn.Name = "RemoveItemBtn";
            RemoveItemBtn.Size = new Size(109, 29);
            RemoveItemBtn.TabIndex = 12;
            RemoveItemBtn.Text = "Remove Item";
            RemoveItemBtn.UseVisualStyleBackColor = true;
            RemoveItemBtn.Click += RemoveItemBtn_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(343, 71);
            button3.Name = "button3";
            button3.Size = new Size(138, 29);
            button3.TabIndex = 13;
            button3.Text = "Clear Order";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ClearCartBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.914634168F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.0853653F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.41711235F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.5828857F));
            tableLayoutPanel1.Size = new Size(500, 561);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(label9, 1, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(7, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(490, 30);
            tableLayoutPanel4.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(248, 0);
            label9.Name = "label9";
            label9.Size = new Size(239, 30);
            label9.TabIndex = 4;
            label9.Text = "Priority Options";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PriorityOrdersTab";
            Size = new Size(500, 561);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox CreatedTextBox;
        private Label label4;
        private Label label3;
        private TextBox IdTextBox;
        private Label label5;
        private ComboBox StatusComboBox;
        private Controls.AddressControl addressControl1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private ListBox OrderItemsListBox;
        private Label label7;
        private Label AmountLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label9;
        private Label label10;
        private ComboBox DeliveryTimeComboBox;
        private TableLayoutPanel tableLayoutPanel6;
        private Button AddItemBtn;
        private Button RemoveItemBtn;
        private Button button3;
    }
}
