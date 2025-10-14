namespace ObjectOrientedPractics.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            itemsTabs1 = new ObjectOrientedPractics.View.Tabs.ItemsTabs();
            tabPage2 = new TabPage();
            customersTab1 = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            tabPage4 = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            tabPage5 = new TabPage();
            ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            tabPage3 = new TabPage();
            ExitSaving = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(984, 561);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(itemsTabs1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(976, 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // itemsTabs1
            // 
            itemsTabs1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsTabs1.Location = new Point(3, 3);
            itemsTabs1.Name = "itemsTabs1";
            itemsTabs1.Size = new Size(970, 527);
            itemsTabs1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(186, 66);
            customersTab1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cartsTab1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(192, 72);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Carts";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(192, 72);
            cartsTab1.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(ordersTab1);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(976, 533);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Orders";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(0, 0);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(976, 533);
            ordersTab1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ExitSaving);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(192, 72);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ExitSaving
            // 
            ExitSaving.AutoSize = true;
            ExitSaving.CheckAlign = ContentAlignment.MiddleRight;
            ExitSaving.Location = new Point(8, 26);
            ExitSaving.Name = "ExitSaving";
            ExitSaving.Size = new Size(201, 19);
            ExitSaving.TabIndex = 0;
            ExitSaving.Text = "Сохранение данных при выходе";
            ExitSaving.UseVisualStyleBackColor = true;
            ExitSaving.CheckedChanged += ExitSaving_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(948, 561);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Tabs.ItemsTabs itemsTabs1;
        private Tabs.CustomersTab customersTab1;
        private TabPage tabPage3;
        private CheckBox ExitSaving;
        private TabPage tabPage4;
        private Tabs.CartsTab cartsTab1;
        private TabPage tabPage5;
        private Tabs.OrdersTab ordersTab1;
    }
}