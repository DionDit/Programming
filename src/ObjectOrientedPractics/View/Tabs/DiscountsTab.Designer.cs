namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            Info = new Label();
            label2 = new Label();
            CalculateBtn = new Button();
            ApplyBtn = new Button();
            UpdateBtn = new Button();
            OrderAmount = new Label();
            label4 = new Label();
            DiscountAmount = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.6518774F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.4505119F));
            tableLayoutPanel1.Controls.Add(Info, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 4, 1);
            tableLayoutPanel1.Controls.Add(CalculateBtn, 0, 2);
            tableLayoutPanel1.Controls.Add(ApplyBtn, 1, 2);
            tableLayoutPanel1.Controls.Add(UpdateBtn, 2, 2);
            tableLayoutPanel1.Controls.Add(OrderAmount, 4, 2);
            tableLayoutPanel1.Controls.Add(label4, 4, 3);
            tableLayoutPanel1.Controls.Add(DiscountAmount, 4, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.808104F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2046928F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.2978725F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4680853F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.2995777F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.4725742F));
            tableLayoutPanel1.Size = new Size(586, 237);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Info
            // 
            Info.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(Info, 3);
            Info.Dock = DockStyle.Fill;
            Info.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Info.Location = new Point(3, 23);
            Info.Name = "Info";
            Info.Size = new Size(345, 38);
            Info.TabIndex = 0;
            Info.Text = "Info:";
            Info.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(433, 23);
            label2.Name = "label2";
            label2.Size = new Size(150, 38);
            label2.TabIndex = 1;
            label2.Text = "Products Amount:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CalculateBtn
            // 
            CalculateBtn.Dock = DockStyle.Fill;
            CalculateBtn.Location = new Point(3, 64);
            CalculateBtn.Name = "CalculateBtn";
            CalculateBtn.Size = new Size(111, 37);
            CalculateBtn.TabIndex = 2;
            CalculateBtn.Text = "Calculate";
            CalculateBtn.UseVisualStyleBackColor = true;
            CalculateBtn.Click += CalculateBtn_Click;
            // 
            // ApplyBtn
            // 
            ApplyBtn.Dock = DockStyle.Fill;
            ApplyBtn.Location = new Point(120, 64);
            ApplyBtn.Name = "ApplyBtn";
            ApplyBtn.Size = new Size(111, 37);
            ApplyBtn.TabIndex = 3;
            ApplyBtn.Text = "Apply";
            ApplyBtn.UseVisualStyleBackColor = true;
            ApplyBtn.Click += ApplyBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Dock = DockStyle.Fill;
            UpdateBtn.Location = new Point(237, 64);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(111, 37);
            UpdateBtn.TabIndex = 4;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // OrderAmount
            // 
            OrderAmount.AutoSize = true;
            OrderAmount.Dock = DockStyle.Fill;
            OrderAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            OrderAmount.Location = new Point(433, 61);
            OrderAmount.Name = "OrderAmount";
            OrderAmount.Size = new Size(150, 43);
            OrderAmount.TabIndex = 5;
            OrderAmount.Text = "0,00 ₽";
            OrderAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(433, 104);
            label4.Name = "label4";
            label4.Size = new Size(127, 19);
            label4.TabIndex = 6;
            label4.Text = "Discount Amount:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DiscountAmount
            // 
            DiscountAmount.AutoSize = true;
            DiscountAmount.Dock = DockStyle.Fill;
            DiscountAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            DiscountAmount.Location = new Point(433, 138);
            DiscountAmount.Name = "DiscountAmount";
            DiscountAmount.Size = new Size(150, 40);
            DiscountAmount.TabIndex = 7;
            DiscountAmount.Text = "0,00 ₽";
            DiscountAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DiscountsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DiscountsTab";
            Size = new Size(586, 237);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label Info;
        private Label label2;
        private Button CalculateBtn;
        private Button ApplyBtn;
        private Button UpdateBtn;
        private Label OrderAmount;
        private Label DiscountAmount;
        private Label label4;
    }
}
