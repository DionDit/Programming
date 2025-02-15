using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Film
    {
        public Film(string Name, int Duration, int ReleaseYear, string Genre, double Rating)
        {
            this.Name = Name;
            this.Duration = Duration;
            this.ReleaseYear = ReleaseYear;
            this.Genre = Genre;
            this.Rating = Rating;
        }
        public Film()
        {

        }
        #region Fields
        /// <summary>
        /// Название фильма
        /// </summary>
        private string _name;
        /// <summary>
        /// Продолжительность фильма
        /// </summary>
        private int _duration;
        /// <summary>
        /// Год выпуска
        /// </summary>
        private int _releaseYear;
        /// <summary>
        /// Жанр фильма
        /// </summary>
        private string _genre;
        /// <summary>
        /// Рейтинг фильма
        /// </summary>
        private double _rating;
        #endregion

        #region Properties
        /// <summary>
        /// Название фильма
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
                    throw new ArgumentException("Невозможное значение названия фильма");
                }
            }
        }
        /// <summary>
        /// Продолжительность фильма
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value > 0)
                {
                    _duration = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение продолжительности фильма");
                }
            }
        }
        /// <summary>
        /// Год выпуска фильма
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                {
                    _releaseYear = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение года выпуска");
                }
            }
        }
        /// <summary>
        /// Жанр фильма
        /// </summary>
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _genre = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение жанра");
                }
            }
        }
        /// <summary>
        /// Рейтинг фильма
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение рейтинга");
                }
            }
        }
        #endregion
    }
}
