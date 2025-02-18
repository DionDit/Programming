namespace Programming.Views.UserControls
{
    partial class MoviesControl
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
            this.label12 = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FilmBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(207, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Rating:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(207, 203);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(131, 20);
            this.RatingTextBox.TabIndex = 22;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(207, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Genre:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(207, 158);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(131, 20);
            this.GenreTextBox.TabIndex = 20;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FindFilmButton_Click);
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(207, 99);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(71, 13);
            this.ReleaseYearLabel.TabIndex = 18;
            this.ReleaseYearLabel.Text = "ReleaseYear:";
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(207, 115);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(131, 20);
            this.ReleaseYearTextBox.TabIndex = 17;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Duration:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(207, 70);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(131, 20);
            this.DurationTextBox.TabIndex = 15;
            this.DurationTextBox.Click += new System.EventHandler(this.DurationTextBox_TextChanged);
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(207, 22);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(131, 20);
            this.NameTextBox.TabIndex = 13;
            this.NameTextBox.Click += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // FilmBox
            // 
            this.FilmBox.FormattingEnabled = true;
            this.FilmBox.Location = new System.Drawing.Point(3, 7);
            this.FilmBox.Name = "FilmBox";
            this.FilmBox.Size = new System.Drawing.Size(198, 368);
            this.FilmBox.TabIndex = 12;
            this.FilmBox.SelectedIndexChanged += new System.EventHandler(this.FilmBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.ReleaseYearTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FilmBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(340, 380);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox FilmBox;
    }
}
