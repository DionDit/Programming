using Programming.Models;

namespace Programming.Views.UserControls
{
    partial class RectanglesCollisionControl
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
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.RectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.RectangleYTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.RectangleXTextBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.RectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectanglePanel = new System.Windows.Forms.Panel();
            this.RectangleBox = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.RectangleRemove = new System.Windows.Forms.Button();
            this.RectangleAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 235);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(104, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "Selected Rectangle:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 257);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 40;
            this.label18.Text = "Id:";
            // 
            // RectangleIdTextBox
            // 
            this.RectangleIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleIdTextBox.Location = new System.Drawing.Point(64, 254);
            this.RectangleIdTextBox.Name = "RectangleIdTextBox";
            this.RectangleIdTextBox.Size = new System.Drawing.Size(131, 20);
            this.RectangleIdTextBox.TabIndex = 31;
            this.RectangleIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputData);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 308);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 13);
            this.label19.TabIndex = 39;
            this.label19.Text = "Y:";
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleYTextBox.Location = new System.Drawing.Point(64, 305);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.Size = new System.Drawing.Size(131, 20);
            this.RectangleYTextBox.TabIndex = 34;
            this.RectangleYTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputData);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(39, 282);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "X:";
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleXTextBox.Location = new System.Drawing.Point(64, 279);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.Size = new System.Drawing.Size(131, 20);
            this.RectangleXTextBox.TabIndex = 32;
            this.RectangleXTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputData);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 334);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Width:";
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(64, 331);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(131, 20);
            this.RectangleWidthTextBox.TabIndex = 36;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 360);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "Height:";
            // 
            // RectangleHeightTextBox
            // 
            this.RectangleHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleHeightTextBox.Location = new System.Drawing.Point(64, 357);
            this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            this.RectangleHeightTextBox.Size = new System.Drawing.Size(131, 20);
            this.RectangleHeightTextBox.TabIndex = 37;
            this.RectangleHeightTextBox.TextChanged += new System.EventHandler(this.RectangleHeightTextBox_TextChanged);
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglePanel.Location = new System.Drawing.Point(355, 7);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(433, 396);
            this.RectanglePanel.TabIndex = 28;
            // 
            // RectangleBox
            // 
            this.RectangleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleBox.FormattingEnabled = true;
            this.RectangleBox.Location = new System.Drawing.Point(12, 29);
            this.RectangleBox.Name = "RectangleBox";
            this.RectangleBox.Size = new System.Drawing.Size(337, 173);
            this.RectangleBox.TabIndex = 27;
            this.RectangleBox.SelectedIndexChanged += new System.EventHandler(this.RectangleBox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Rectangles:";
            // 
            // RectangleRemove
            // 
            this.RectangleRemove.BackgroundImage = global::Programming.Properties.Resources.RecRemove1;
            this.RectangleRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleRemove.FlatAppearance.BorderSize = 0;
            this.RectangleRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RectangleRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleRemove.Location = new System.Drawing.Point(174, 208);
            this.RectangleRemove.Name = "RectangleRemove";
            this.RectangleRemove.Size = new System.Drawing.Size(49, 31);
            this.RectangleRemove.TabIndex = 30;
            this.RectangleRemove.UseVisualStyleBackColor = true;
            this.RectangleRemove.Click += new System.EventHandler(this.RectangleRemove_Click);
            this.RectangleRemove.MouseLeave += new System.EventHandler(this.RectangleRemove_MouseLeave);
            this.RectangleRemove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RectangleRemove_MouseMove);
            // 
            // RectangleAdd
            // 
            this.RectangleAdd.BackColor = System.Drawing.Color.Transparent;
            this.RectangleAdd.BackgroundImage = global::Programming.Properties.Resources.RecAdd1;
            this.RectangleAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleAdd.CausesValidation = false;
            this.RectangleAdd.FlatAppearance.BorderSize = 0;
            this.RectangleAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RectangleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleAdd.Location = new System.Drawing.Point(129, 208);
            this.RectangleAdd.Name = "RectangleAdd";
            this.RectangleAdd.Size = new System.Drawing.Size(49, 31);
            this.RectangleAdd.TabIndex = 29;
            this.RectangleAdd.TabStop = false;
            this.RectangleAdd.UseVisualStyleBackColor = false;
            this.RectangleAdd.Click += new System.EventHandler(this.RectangleAdd_Click);
            this.RectangleAdd.MouseLeave += new System.EventHandler(this.RectangleAdd_MouseLeave);
            this.RectangleAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RectangleAdd_MouseMove);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.RectangleIdTextBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.RectangleYTextBox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.RectangleXTextBox);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.RectangleWidthTextBox);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.RectangleHeightTextBox);
            this.Controls.Add(this.RectangleRemove);
            this.Controls.Add(this.RectangleAdd);
            this.Controls.Add(this.RectanglePanel);
            this.Controls.Add(this.RectangleBox);
            this.Controls.Add(this.label17);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(800, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox RectangleIdTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox RectangleYTextBox;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox RectangleXTextBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox RectangleWidthTextBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox RectangleHeightTextBox;
        private System.Windows.Forms.Button RectangleRemove;
        private System.Windows.Forms.Button RectangleAdd;
        private System.Windows.Forms.Panel RectanglePanel;
        private System.Windows.Forms.ListBox RectangleBox;
        private System.Windows.Forms.Label label17;
    }
}
