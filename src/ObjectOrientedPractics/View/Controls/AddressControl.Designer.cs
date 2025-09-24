namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            label3 = new Label();
            label4 = new Label();
            BuildingTextBox = new TextBox();
            CountryTextBox = new TextBox();
            IndexTextBox = new TextBox();
            StreetTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            CityTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.041666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.458334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(BuildingTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(CountryTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(IndexTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(StreetTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(ApartmentTextBox, 3, 4);
            tableLayoutPanel1.Controls.Add(CityTextBox, 4, 2);
            tableLayoutPanel1.Controls.Add(label6, 3, 2);
            tableLayoutPanel1.Controls.Add(label7, 2, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.2466478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.4F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.8F));
            tableLayoutPanel1.Size = new Size(480, 250);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 32);
            label2.TabIndex = 5;
            label2.Text = "Delivery Address";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(108, 35);
            label1.TabIndex = 6;
            label1.Text = "Post index:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(3, 67);
            label3.Name = "label3";
            label3.Size = new Size(108, 38);
            label3.TabIndex = 7;
            label3.Text = "Country:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(108, 43);
            label4.TabIndex = 8;
            label4.Text = "Street:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.Location = new Point(117, 151);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(71, 23);
            BuildingTextBox.TabIndex = 13;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(CountryTextBox, 2);
            CountryTextBox.Location = new Point(117, 70);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(150, 23);
            CountryTextBox.TabIndex = 10;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // IndexTextBox
            // 
            IndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(IndexTextBox, 2);
            IndexTextBox.Location = new Point(117, 35);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(111, 23);
            IndexTextBox.TabIndex = 14;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(StreetTextBox, 5);
            StreetTextBox.Location = new Point(117, 108);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(360, 23);
            StreetTextBox.TabIndex = 15;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.SetColumnSpan(ApartmentTextBox, 2);
            ApartmentTextBox.Location = new Point(273, 151);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(71, 23);
            ApartmentTextBox.TabIndex = 17;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(CityTextBox, 2);
            CityTextBox.Location = new Point(315, 70);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(162, 23);
            CityTextBox.TabIndex = 12;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 9F);
            label6.Location = new Point(273, 67);
            label6.Name = "label6";
            label6.Size = new Size(36, 38);
            label6.TabIndex = 11;
            label6.Text = "City:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(194, 151);
            label7.Margin = new Padding(3, 3, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(73, 26);
            label7.TabIndex = 16;
            label7.Text = "Apartment:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(3, 151);
            label5.Margin = new Padding(3, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 26);
            label5.TabIndex = 9;
            label5.Text = "Building:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "AddressControl";
            Size = new Size(480, 250);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox CountryTextBox;
        private TextBox BuildingTextBox;
        private Label label6;
        private TextBox CityTextBox;
        private TextBox IndexTextBox;
        private TextBox StreetTextBox;
        private Label label7;
        private TextBox ApartmentTextBox;
    }
}
