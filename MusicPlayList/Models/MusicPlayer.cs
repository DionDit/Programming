using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace MusicPlayList.Models
{
    /// <summary>
    /// Управление музыкальным плеером
    /// </summary>
    public static class MusicPlayer
    {
        /// <summary>
        /// Музыкальный плеер
        /// </summary>
        private static WindowsMediaPlayer Player = new WindowsMediaPlayer();

        /// <summary>
        /// Запуск музыки
        /// </summary>
        /// <param name="url">Адрес воспроизведения песни</param>
        public static void PlayMusic(string url)
        {
            Player.URL = url;
            Player.controls.play();
        }

        /// <summary>
        /// Пауза воспроизведенной музыки
        /// </summary>
        public static void StopMusic()
        {
            Player.controls.stop();
        }
    }
}
