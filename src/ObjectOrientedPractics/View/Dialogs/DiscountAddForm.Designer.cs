namespace ObjectOrientedPractics.View.Dialogs
{
    partial class DiscountAddForm
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
            label5 = new Label();
            label1 = new Label();
            CategoryComboBox = new ComboBox();
            OkBtn = new Button();
            CancelBtn = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 19);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 11;
            label5.Text = "Percent Discount:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 12;
            label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(76, 52);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(227, 23);
            CategoryComboBox.TabIndex = 13;
            // 
            // OkBtn
            // 
            OkBtn.Location = new Point(102, 83);
            OkBtn.Name = "OkBtn";
            OkBtn.Size = new Size(95, 34);
            OkBtn.TabIndex = 14;
            OkBtn.Text = "Ok";
            OkBtn.UseVisualStyleBackColor = true;
            OkBtn.Click += OkBtn_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(208, 83);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(95, 34);
            CancelBtn.TabIndex = 15;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // DiscountAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 129);
            Controls.Add(CancelBtn);
            Controls.Add(OkBtn);
            Controls.Add(CategoryComboBox);
            Controls.Add(label1);
            Controls.Add(label5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DiscountAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private ComboBox CategoryComboBox;
        private Button OkBtn;
        private Button CancelBtn;
    }
}