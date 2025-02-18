using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    /// <summary>
    /// Фильм.
    /// </summary>
    public class Film
    {
        #region Fields
        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _name;

        /// <summary>
        /// Продолжительность фильма.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выпуска.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Film"/>.
        /// </summary>
        /// <param name="Name">Название.</param>
        /// <param name="Duration">Продолжительность.</param>
        /// <param name="ReleaseYear">Год выпуска.</param>
        /// <param name="Genre">Жанр.</param>
        /// <param name="Rating">Рейтинг.</param>
        public Film(string Name, int Duration, int ReleaseYear, string Genre, double Rating)
        {
            this.Name = Name;
            this.Duration = Duration;
            this.ReleaseYear = ReleaseYear;
            this.Genre = Genre;
            this.Rating = Rating;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Film"/>.
        /// </summary>
        public Film()
        {

        }

        #region Properties
        /// <summary>
        /// Название фильма.
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
        /// Продолжительность фильма.
        /// </summary>
        public int Duration
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

        /// <summary>
        /// Год выпуска фильма.
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if (Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear)))
                {
                    _releaseYear = value;
                }
            }
        }

        /// <summary>
        /// Жанр фильма.
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
        /// Рейтинг фильма.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (Validator.AssertValueInRange(value, 0, 10, nameof(Rating)))
                {
                    _rating = value;
                }
            }
        }
        #endregion

        /// <summary>
        /// Метод переопределения ToString().
        /// </summary>
        /// <returns>Строку с информацией об фильме.</returns>
        public override string ToString() => $"Film: {Name}";
    }
}
