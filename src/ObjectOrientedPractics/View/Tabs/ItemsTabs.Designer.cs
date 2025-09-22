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
            panel3 = new Panel();
            NameTextBox = new RichTextBox();
            label6 = new Label();
            DescriptionTextBox = new RichTextBox();
            label5 = new Label();
            CostTextBox = new TextBox();
            label4 = new Label();
            IdTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            AddRandomBtn = new Button();
            RemoveBtn = new Button();
            AddBtn = new Button();
            ItemBox = new ListBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(NameTextBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(DescriptionTextBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(CostTextBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(IdTextBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(496, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(471, 521);
            panel3.TabIndex = 1;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(7, 114);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(461, 96);
            NameTextBox.TabIndex = 12;
            NameTextBox.Text = "";
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 96);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Name:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(7, 239);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(461, 96);
            DescriptionTextBox.TabIndex = 10;
            DescriptionTextBox.Text = "";
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 221);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 9;
            label5.Text = "Description:";
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(51, 59);
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
            // IdTextBox
            // 
            IdTextBox.Location = new Point(51, 30);
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
            label2.Size = new Size(91, 15);
            label2.TabIndex = 4;
            label2.Text = "Selected Items";
            // 
            // panel2
            // 
            panel2.Controls.Add(AddRandomBtn);
            panel2.Controls.Add(RemoveBtn);
            panel2.Controls.Add(AddBtn);
            panel2.Controls.Add(ItemBox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(487, 524);
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
            // ItemBox
            // 
            ItemBox.FormattingEnabled = true;
            ItemBox.Location = new Point(3, 22);
            ItemBox.Name = "ItemBox";
            ItemBox.Size = new Size(481, 454);
            ItemBox.TabIndex = 1;
            ItemBox.SelectedIndexChanged += ItemBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(970, 527);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // ItemsTabs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "ItemsTabs";
            Size = new Size(970, 527);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button AddBtn;
        private ListBox ItemBox;
        private Button RemoveBtn;
        private Panel panel3;
        private RichTextBox NameTextBox;
        private Label label6;
        private RichTextBox DescriptionTextBox;
        private Label label5;
        private TextBox CostTextBox;
        private Label label4;
        private TextBox IdTextBox;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button AddRandomBtn;
    }
}
