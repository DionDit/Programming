namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            label1 = new Label();
            ItemsListBox = new ListBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            CustomersComboBox = new ComboBox();
            label3 = new Label();
            CartListBox = new ListBox();
            label4 = new Label();
            AmountLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            CreateOrderBtn = new Button();
            RemoveItemBtn = new Button();
            ClearCartBtn = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            AddToCartBtn = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.5162621F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.4837379F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(ItemsListBox, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.882353F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.38325F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.55614948F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(984, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 33);
            label1.TabIndex = 0;
            label1.Text = "Items";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(3, 36);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(373, 473);
            ItemsListBox.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.1869783F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.81302F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(CustomersComboBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(CartListBox, 0, 2);
            tableLayoutPanel2.Controls.Add(label4, 1, 4);
            tableLayoutPanel2.Controls.Add(AmountLabel, 1, 5);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 6);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(382, 36);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.85440636F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1532564F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.523809F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.37548F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 4.597701F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 7.47126436F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 8.812261F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20.8812256F));
            tableLayoutPanel2.Size = new Size(599, 522);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 40);
            label2.TabIndex = 4;
            label2.Text = "Customer:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Dock = DockStyle.Fill;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(76, 9);
            CustomersComboBox.Margin = new Padding(3, 9, 3, 3);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(520, 23);
            CustomersComboBox.TabIndex = 5;
            CustomersComboBox.SelectedValueChanged += CustomersComboBox_SelectedValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 40);
            label3.Margin = new Padding(3, 0, 35, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 52);
            label3.TabIndex = 6;
            label3.Text = "Cart:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CartListBox
            // 
            tableLayoutPanel2.SetColumnSpan(CartListBox, 2);
            CartListBox.Dock = DockStyle.Fill;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(9, 95);
            CartListBox.Margin = new Padding(9, 3, 3, 3);
            CartListBox.Name = "CartListBox";
            tableLayoutPanel2.SetRowSpan(CartListBox, 2);
            CartListBox.Size = new Size(587, 208);
            CartListBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(76, 306);
            label4.Name = "label4";
            label4.Size = new Size(520, 23);
            label4.TabIndex = 8;
            label4.Text = "Amount:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Dock = DockStyle.Fill;
            AmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AmountLabel.Location = new Point(76, 329);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(520, 38);
            AmountLabel.TabIndex = 9;
            AmountLabel.Text = "0,00 ₽";
            AmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(CreateOrderBtn, 0, 0);
            tableLayoutPanel3.Controls.Add(RemoveItemBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(ClearCartBtn, 3, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 370);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(593, 39);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // CreateOrderBtn
            // 
            CreateOrderBtn.Dock = DockStyle.Fill;
            CreateOrderBtn.Location = new Point(3, 3);
            CreateOrderBtn.Name = "CreateOrderBtn";
            CreateOrderBtn.Size = new Size(142, 33);
            CreateOrderBtn.TabIndex = 0;
            CreateOrderBtn.Text = "Create Order";
            CreateOrderBtn.UseVisualStyleBackColor = true;
            CreateOrderBtn.Click += CreateOrderBtn_Click;
            // 
            // RemoveItemBtn
            // 
            RemoveItemBtn.Dock = DockStyle.Fill;
            RemoveItemBtn.Location = new Point(299, 3);
            RemoveItemBtn.Name = "RemoveItemBtn";
            RemoveItemBtn.Size = new Size(142, 33);
            RemoveItemBtn.TabIndex = 1;
            RemoveItemBtn.Text = "Remove Item";
            RemoveItemBtn.UseVisualStyleBackColor = true;
            RemoveItemBtn.Click += RemoveItemBtn_Click;
            // 
            // ClearCartBtn
            // 
            ClearCartBtn.Dock = DockStyle.Fill;
            ClearCartBtn.Location = new Point(447, 3);
            ClearCartBtn.Name = "ClearCartBtn";
            ClearCartBtn.Size = new Size(143, 33);
            ClearCartBtn.TabIndex = 2;
            ClearCartBtn.Text = "Clear Cart";
            ClearCartBtn.UseVisualStyleBackColor = true;
            ClearCartBtn.Click += ClearCartBtn_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(AddToCartBtn, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 515);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(373, 43);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // AddToCartBtn
            // 
            AddToCartBtn.Dock = DockStyle.Fill;
            AddToCartBtn.Location = new Point(3, 3);
            AddToCartBtn.Name = "AddToCartBtn";
            AddToCartBtn.Size = new Size(118, 37);
            AddToCartBtn.TabIndex = 0;
            AddToCartBtn.Text = "Add To Cart";
            AddToCartBtn.UseVisualStyleBackColor = true;
            AddToCartBtn.Click += AddToCartBtn_Click;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CartsTab";
            Size = new Size(984, 561);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ListBox ItemsListBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private ComboBox CustomersComboBox;
        private Label label3;
        private ListBox CartListBox;
        private Label label4;
        private Label AmountLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button RemoveItemBtn;
        private Button CreateOrderBtn;
        private Button ClearCartBtn;
        private TableLayoutPanel tableLayoutPanel4;
        private Button AddToCartBtn;
    }
}
