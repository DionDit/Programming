namespace ObjectOrientedPractics.View.Dialogs
{
    partial class CustomerAddForm
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
            panel3 = new Panel();
            button1 = new Button();
            AddressTextBox = new RichTextBox();
            label6 = new Label();
            FullNameTextBox = new TextBox();
            label4 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(AddressTextBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(FullNameTextBox);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 243);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(120, 195);
            button1.Name = "button1";
            button1.Size = new Size(123, 37);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(77, 93);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(268, 96);
            AddressTextBox.TabIndex = 12;
            AddressTextBox.Text = "";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(103, 9);
            label2.Name = "label2";
            label2.Size = new Size(169, 25);
            label2.TabIndex = 4;
            label2.Text = "Adding Customer";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 243);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerAddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adding Customer";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private RichTextBox AddressTextBox;
        private Label label6;
        private TextBox FullNameTextBox;
        private Label label4;
        private Label label2;
        private Button button1;
    }
}