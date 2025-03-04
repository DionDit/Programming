using MusicPlayList.Models;
using MusicPlayList.Properties;
using MusicPlayList.Views.UserControls;
using Programming.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MusicPlayList.Views.Forms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Выбранная песня
        /// </summary>
        private Song _currentSong;
        public MainForm()
        {
            InitializeComponent();
            FileManager.ReadFile();
            UpdateSongList();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        
        /// <summary>
        /// Обновление списка песен
        /// </summary>
        private void UpdateSongList()
        {
            flowLayoutPanel1.Controls.Clear();
            Song.Songs.ForEach(x =>
            {
                SelectedSongControl selectedSongControl = new SelectedSongControl(x, "view");
                selectedSongControl.SongSelectChanged += SelectedSongControl_SongSelectChanged;
                flowLayoutPanel1.Controls.Add(selectedSongControl);
            });
        }

        /// <summary>
        /// Выбор песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedSongControl_SongSelectChanged(object sender, Song e)
        {
            _currentSong = e;
            groupBox1.Visible = true;
            if (_currentSong.Image == null)
            {
                pictureBox1.Image = Resources.NoPhoto;
            }
            else
            {
                using (var ms = new MemoryStream(e.Image))
                {
                    pictureBox1.Image = new Bitmap(ms);
                }
            }
            UpdateInput();
            UpdateSongList();
        }

        /// <summary>
        /// Обновление полей ввода
        /// </summary>
        public void UpdateInput()
        {
            NameSong.Text = _currentSong.Name;
            ArtisctSong.Text = _currentSong.Artist;
            DurationSong.Text = _currentSong.Duration.ToString();
            GenreSong.Text = _currentSong.Genre;
        }

        /// <summary>
        /// Поиск песни по запросу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SongNameTextBox.Text))
            {
                pictureBox2.Visible = true;
                var Songs = await Task.Run(() => MusicParser.GetSongs(SongNameTextBox.Text));
                if (Songs.Count > 0)
                {
                    pictureBox2.Visible = false;
                    new SelectMusicForm(Songs).ShowDialog();
                    UpdateSongList();
                }
                else
                {
                    MessageBox.Show("Ничего не найдено! Повторите поиск указав другое название.","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    pictureBox2.Visible = false;
                }
                SongNameTextBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Выбор изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog File = new OpenFileDialog();
            if (File.ShowDialog() == DialogResult.OK)
            {
                System.Drawing.Image image = Bitmap.FromFile(File.FileName);
                using (var ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    _currentSong.Image = ms.ToArray();

                }
                pictureBox1.Image = image;
            }
        }

        /// <summary>
        /// Изменение названия песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameSong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentSong.Name = NameSong.Text;
                Song.Songs[Song.Songs.IndexOf(_currentSong)].Name = _currentSong.Name;
                NameSong.BackColor = AppColors.BaseInput;
            }
            catch
            {
                NameSong.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение исполнителя песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArtisctSong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentSong.Artist = ArtisctSong.Text;
                Song.Songs[Song.Songs.IndexOf(_currentSong)].Artist = _currentSong.Artist;
                ArtisctSong.BackColor = AppColors.BaseInput;
            }
            catch
            {
                ArtisctSong.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение продолжительности песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DurationSong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentSong.Duration = Convert.ToInt32(DurationSong.Text);
                Song.Songs[Song.Songs.IndexOf(_currentSong)].Duration = _currentSong.Duration;
                DurationSong.BackColor = AppColors.BaseInput;
            }
            catch
            {
                DurationSong.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение жанра песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenreSong_TextChanged(object sender, EventArgs e)
        {
            _currentSong.Genre = GenreSong.Text;
            Song.Songs[Song.Songs.IndexOf(_currentSong)].Genre = _currentSong.Genre;
        }

        /// <summary>
        /// Действия при закрытии программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileManager.SaveChanges();
        }

        /// <summary>
        /// Удаление выбранной песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            Song.Songs.Remove(_currentSong);
            if (Song.Songs.Count > 0)
            {
                UpdateSongList();
                _currentSong = Song.Songs.Last();
                UpdateInput();
            }
            else
            {
                groupBox1.Visible = false;
            }
            FileManager.SaveChanges();

        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.BackColor = AppColors.BaseInput;
            button4.BackgroundImage = Resources.RecRemove2;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = AppColors.BaseInput;
            button4.BackgroundImage = Resources.RecRemove1;
        }

    }
}
