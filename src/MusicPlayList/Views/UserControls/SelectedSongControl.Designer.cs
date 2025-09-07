namespace MusicPlayList.Views.UserControls
{
    partial class SelectedSongControl
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
            this.Artist = new System.Windows.Forms.Label();
            this.SongName = new System.Windows.Forms.Label();
            this.Duration = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Location = new System.Drawing.Point(69, 31);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(80, 13);
            this.Artist.TabIndex = 1;
            this.Artist.Text = "Исполнитель: ";
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Location = new System.Drawing.Point(69, 10);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(63, 13);
            this.SongName.TabIndex = 2;
            this.SongName.Text = "Название: ";
            // 
            // Duration
            // 
            this.Duration.AutoSize = true;
            this.Duration.Location = new System.Drawing.Point(69, 50);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(111, 13);
            this.Duration.TabIndex = 3;
            this.Duration.Text = "Продолжительность";
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(259, 18);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(50, 23);
            this.PlayButton.TabIndex = 4;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::MusicPlayList.Properties.Resources.NoPhoto;
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SelectedSongControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.Artist);
            this.Name = "SelectedSongControl";
            this.Size = new System.Drawing.Size(312, 72);
            this.Click += new System.EventHandler(this.SelectedSongControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Label Duration;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
