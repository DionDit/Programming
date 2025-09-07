using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Drawing;
using Programming.Models;

namespace MusicPlayList.Models
{
    /// <summary>
    /// Класс реализующий песню
    /// </summary>
    [DataContract]
    public class Song
    {

        #region Field
        /// <summary>
        /// Название
        /// </summary>
        private string _name;

        /// <summary>
        /// Исполнитель
        /// </summary>
        private string _artist;

        /// <summary>
        /// Продолжительность
        /// </summary>
        private int _duration;

        /// <summary>
        /// Жанр
        /// </summary>
        private string _genre;

        /// <summary>
        /// Изображение
        /// </summary>
        private byte[] _image;

        /// <summary>
        /// Адрес воспроизведения песни
        /// </summary>
        private string _musicPlay;
        #endregion

        #region Property
        /// <summary>
        /// Общий список сохраненных песен на компьютере
        /// </summary>
        public static List<Song> Songs { get; set; } = new List<Song>();

        /// <summary>
        /// Название
        /// </summary>
        [DataMember(Name = "name")]
        public string Name
        {
            get 
            { 
                return _name;
            }
            set 
            {
                if (Validator.AssertValueInRange(value.Length, 1, 50, nameof(Name)))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Исполнитель
        /// </summary>
        [DataMember(Name = "artist")]
        public string Artist
        {
            get 
            { 
                return _artist;
            }
            set
            {
                if (Validator.AssertValueInRange(value.Length, 1, 50, nameof(Artist)))
                {
                    _artist = value;
                }
            }
        }

        /// <summary>
        /// Исполнитель
        /// </summary>
        [DataMember(Name = "duration")]
        public int Duration
        {
            get 
            { 
                return _duration;
            }
            set
            {
                if (Validator.AssertValueInRange(value, 1, 7200, nameof(Duration)))
                {
                    _duration = value;
                }
            }
        }

        /// <summary>
        /// Жанр
        /// </summary>
        [DataMember(Name = "genre")]
        public string Genre
        {
            get 
            { 
                return _genre;
            }
            set 
            {
                _genre = value; 
            }
        }

        /// <summary>
        /// Адрес воспроизведения песни
        /// </summary>
        [DataMember(Name = "musicPlay")]
        public string MusicPlay
        {
            get { return _musicPlay; }
            set { _musicPlay = value; }
        }

        /// <summary>
        /// Изображение
        /// </summary>
        [DataMember(Name = "image")]
        public byte[] Image
        {
            get { return _image; }
            set { _image = value; }
        }
        #endregion

        /// <summary>
        /// Конструктор класса <see cref="Song"/>
        /// </summary>
        public Song()
        {
                
        }

        /// <summary>
        /// Конструктор класса <see cref="Song"/>
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="artist">Исполнитель</param>
        /// <param name="duration">Продолжительность</param>
        /// <param name="genre">Жанр</param>
        /// <param name="image">Изображение</param>
        /// <param name="musicplay">Адрес воспроизведения песни</param>
        public Song(string name, string artist, int duration, string genre, byte[] image, string musicplay)
        {
            Name = name;
            Artist = artist;
            Duration = duration;
            Genre = genre;
            Image = image;
            MusicPlay = musicplay;
        }

        /// <summary>
        /// Сериализация <see cref="List{Song}"/>
        /// </summary>
        /// <param name="songs">Список песен</param>
        /// <returns></returns>
        public static string CreateJSON(List<Song> songs)
        {
            using (MemoryStream MemoryStream = new MemoryStream())
            {
                using (StreamReader StreamReader = new StreamReader(MemoryStream))
                {
                    DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(List<Song>));
                    json.WriteObject(MemoryStream, songs);
                    MemoryStream.Position = 0;
                    return StreamReader.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Десериализация <see cref="List{Song}"/>
        /// </summary>
        /// <param name="songs">Данные JSON</param>
        /// <returns></returns>
        public static List<Song> CreateSongFromJSON(string songs)
        {
            DataContractJsonSerializer Json = new DataContractJsonSerializer(typeof(List<Song>));
            using (MemoryStream Stream = new MemoryStream(Encoding.Unicode.GetBytes(songs)))
            {
                return Json.ReadObject(Stream) as List<Song>;
            }
        }
    }
}
