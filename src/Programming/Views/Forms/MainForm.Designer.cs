namespace Programming.Views.Forms
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
            this.MainFormTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SeasonBox = new System.Windows.Forms.GroupBox();
            this.WeekDayParseBox = new System.Windows.Forms.GroupBox();
            this.Enumerations = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SeasonControl = new Programming.Views.UserControls.SeasonControl();
            this.weekDayParsingControl1 = new Programming.Views.UserControls.WeekDayParsingControl();
            this.enumerationsControl1 = new Programming.Views.UserControls.EnumerationsControl();
            this.rectanglesControl1 = new Programming.Views.UserControls.RectanglesControl();
            this.moviesControl1 = new Programming.Views.UserControls.MoviesControl();
            this.rectanglesCollisionControl1 = new Programming.Views.UserControls.RectanglesCollisionControl();
            this.MainFormTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SeasonBox.SuspendLayout();
            this.WeekDayParseBox.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTab
            // 
            this.MainFormTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFormTab.Controls.Add(this.tabPage1);
            this.MainFormTab.Controls.Add(this.tabPage2);
            this.MainFormTab.Controls.Add(this.tabPage3);
            this.MainFormTab.Controls.Add(this.tabPage4);
            this.MainFormTab.Location = new System.Drawing.Point(0, 0);
            this.MainFormTab.Name = "MainFormTab";
            this.MainFormTab.SelectedIndex = 0;
            this.MainFormTab.Size = new System.Drawing.Size(800, 433);
            this.MainFormTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.SeasonBox);
            this.tabPage1.Controls.Add(this.WeekDayParseBox);
            this.tabPage1.Controls.Add(this.Enumerations);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            // 
            // SeasonBox
            // 
            this.SeasonBox.Controls.Add(this.SeasonControl);
            this.SeasonBox.Location = new System.Drawing.Point(440, 274);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(344, 125);
            this.SeasonBox.TabIndex = 4;
            this.SeasonBox.TabStop = false;
            this.SeasonBox.Text = "Season Handle";
            // 
            // WeekDayParseBox
            // 
            this.WeekDayParseBox.Controls.Add(this.weekDayParsingControl1);
            this.WeekDayParseBox.Location = new System.Drawing.Point(8, 274);
            this.WeekDayParseBox.Name = "WeekDayParseBox";
            this.WeekDayParseBox.Size = new System.Drawing.Size(426, 125);
            this.WeekDayParseBox.TabIndex = 3;
            this.WeekDayParseBox.TabStop = false;
            this.WeekDayParseBox.Text = "WeekDay Parsing";
            // 
            // Enumerations
            // 
            this.Enumerations.Controls.Add(this.enumerationsControl1);
            this.Enumerations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enumerations.Location = new System.Drawing.Point(3, 3);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Size = new System.Drawing.Size(786, 401);
            this.Enumerations.TabIndex = 2;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rectanglesControl1);
            this.groupBox1.Location = new System.Drawing.Point(8, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rectangles";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 407);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Films";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moviesControl1);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Films";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.rectanglesCollisionControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 407);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rectangles";
            // 
            // SeasonControl
            // 
            this.SeasonControl.BackColor = System.Drawing.Color.Transparent;
            this.SeasonControl.Location = new System.Drawing.Point(6, 36);
            this.SeasonControl.Name = "SeasonControl";
            this.SeasonControl.Size = new System.Drawing.Size(334, 53);
            this.SeasonControl.TabIndex = 0;
            // 
            // weekDayParsingControl1
            // 
            this.weekDayParsingControl1.BackColor = System.Drawing.Color.Transparent;
            this.weekDayParsingControl1.Location = new System.Drawing.Point(27, 27);
            this.weekDayParsingControl1.Name = "weekDayParsingControl1";
            this.weekDayParsingControl1.Size = new System.Drawing.Size(372, 92);
            this.weekDayParsingControl1.TabIndex = 0;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.BackColor = System.Drawing.Color.Transparent;
            this.enumerationsControl1.Location = new System.Drawing.Point(0, 0);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(464, 262);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.BackColor = System.Drawing.Color.Transparent;
            this.rectanglesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 16);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(341, 377);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // moviesControl1
            // 
            this.moviesControl1.BackColor = System.Drawing.Color.Transparent;
            this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesControl1.Location = new System.Drawing.Point(3, 16);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(341, 377);
            this.moviesControl1.TabIndex = 2;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.BackColor = System.Drawing.Color.Transparent;
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(792, 407);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 433);
            this.Controls.Add(this.MainFormTab);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.MainFormTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SeasonBox.ResumeLayout(false);
            this.WeekDayParseBox.ResumeLayout(false);
            this.Enumerations.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainFormTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox Enumerations;
        private System.Windows.Forms.GroupBox WeekDayParseBox;
        private System.Windows.Forms.GroupBox SeasonBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage4;
        private UserControls.RectanglesCollisionControl rectanglesCollisionControl1;
        private UserControls.EnumerationsControl enumerationsControl1;
        private UserControls.WeekDayParsingControl weekDayParsingControl1;
        private UserControls.RectanglesControl rectanglesControl1;
        private UserControls.MoviesControl moviesControl1;
        private UserControls.SeasonControl SeasonControl;
    }
}