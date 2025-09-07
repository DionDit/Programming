using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    /// <summary>
    /// Песня.
    /// </summary>
    public class Song
    {
        #region Fields
        /// <summary>
        /// Название.
        /// </summary>
        private string _name;

        /// <summary>
        /// Исполнитель.
        /// </summary>
        private string _artist;

        /// <summary>
        /// Продолжительность.
        /// </summary>
        private double _duration;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="Name">Название.</param>
        /// <param name="Artist">Исполнитель.</param>
        /// <param name="Duration">Продолжительность.</param>
        public Song(string Name, string Artist, double Duration)
        {
            this.Name = Name;
            this.Artist = Artist;
            this.Duration = Duration;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        #region Properties
        /// <summary>
        /// Название.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение имени");
                }
            }
        }

        /// <summary>
        /// Исполнитель.
        /// </summary>
        public string Artist
        {
            get
            {
                return _artist;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _artist = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение исполнителя");
                }
            }
        }

        /// <summary>
        /// Продолжительность.
        /// </summary>
        public double Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Duration)))
                {
                    _duration = value;
                }
            }
        }
        #endregion
    }
}
