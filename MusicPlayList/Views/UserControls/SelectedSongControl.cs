using MusicPlayList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            switch (parametr)
            {
                case "create":
                    _song = song;
                    SongName.Text = $"Название: {_song.Name}";
                    Artist.Text = $"Artist";
                    break;
                case "view":
                    _song = song;
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
            Song.Songs.Add(_song);
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
