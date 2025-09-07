using MusicPlayList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayList.Views.UserControls
{
    public partial class SelectedSongControl : UserControl
    {
        /// <summary>
        /// Событие возникающие при выборе песни
        /// </summary>
        public event EventHandler<Song> SongSelectChanged;

        /// <summary>
        /// Вызов события выбора песни
        /// </summary>
        /// <param name="song"></param>
        protected virtual void OnSongSelectChanged(Song song) => SongSelectChanged?.Invoke(this, _song);

        /// <summary>
        /// Статус воспроизведения песни
        /// </summary>
        private bool _isPlay = false;

        /// <summary>
        /// Экземляр класса песни <see cref="Song"/>
        /// </summary>
        private Song _song;

        /// <summary>
        /// Конструктор элемента управления
        /// </summary>
        /// <param name="song">Песня</param>
        /// <param name="parametr">Параметр отображения</param>
        public SelectedSongControl(Song song, string parametr)
        {
            InitializeComponent();
            _song = song;
            Duration.Text = $"Продолжительность: {(_song.Duration / 60.0).ToString().Replace(",",":")} мин.";
            switch (parametr)
            {
                case "create":
                    SongName.Text = $"Название: {_song.Name}";
                    Artist.Text = $"Исполнитель: {_song.Artist}";
                    break;
                case "view":
                    if (_song.Image != null)
                    {
                        using (var ms = new MemoryStream(_song.Image))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    SongName.Text = $"Название: {_song.Name}";
                    Artist.Text = $"Исполнитель: {_song.Artist}";
                    PlayButton.Location = new Point(259,22);
                    button2.Visible = false;
                    break;
            }
        }

        /// <summary>
        /// Событие воспроизведения песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (_isPlay)
            {
                _isPlay = false;
                PlayButton.Text = "Play";
                MusicPlayer.StopMusic();


            }
            else
            {
                _isPlay = true;

                PlayButton.Text = "Stop";
                MusicPlayer.PlayMusic(_song.MusicPlay);
            }
        }

        /// <summary>
        /// Добавление песни в сохраненный список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы успешно добавили песню","Успех",MessageBoxButtons.OK, MessageBoxIcon.Information);
            Song.Songs.Add(_song);
            button2.Visible = false;
        }

        /// <summary>
        /// Выбор песни
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedSongControl_Click(object sender, EventArgs e)
        {
            OnSongSelectChanged(_song);
        }
    }
}
