using Programming.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Views.UserControls
{

    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Экземпляр случайных значений.
        /// </summary>
        private static Random rnd = new Random();

        /// <summary>
        /// Список названий фильмов.
        /// </summary>
        private List<string> FilmName = new List<string>() { "Toy Story", "Cast Away", "(500) Days of Summer", "Despicable Me 3", "The Social Network", "The Hunger Games", "Forrest Gump", "Wonder", "Beauty and the Beast", "Titanic", "Harry Potter", "Pirates of the Caribbean" };
        
        /// <summary>
        /// Список фильмов.
        /// </summary>
        private List<Film> _films;
       
        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Film _currentFilm;
        public MoviesControl()
        {
            InitializeComponent();
            _films = new List<Film>();

            for (int i = 0; i < 5; i++)
            {
                _films.Add(new Film(FilmName[rnd.Next(0,12)], rnd.Next(1, 4), rnd.Next(1980, 2025), "Horror", Convert.ToDouble(rnd.Next(1, 11))));
            }

            FilmBox.DataSource = _films;
        }

        /// <summary>
        /// Изменение выбранного фильма.
        /// </summary>
        private void FilmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = FilmBox.SelectedItem as Film;
            NameTextBox.Text = _currentFilm.Name;
            DurationTextBox.Text = _currentFilm.Duration.ToString();
            ReleaseYearTextBox.Text = _currentFilm.ReleaseYear.ToString();
            GenreTextBox.Text = _currentFilm.Genre.ToString();
            RatingTextBox.Text = _currentFilm.Rating.ToString();
        }

        /// <summary>
        /// Поиск фильма с максимальным рейтингом.
        /// </summary>
        private int FindFilmWithMaxRating(List<Film> Films)
        {
            double maxRating = 0;
            int Index = 0;
            for (int i = 0; i < Films.Count; i++)
            {
                if (Films[i].Rating > maxRating)
                {
                    maxRating = Films[i].Rating;
                    Index = i;
                }
            }
            return Index;
        }

        /// <summary>
        /// Поиск фильма с максимальным рейтингом.
        /// </summary>
        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            FilmBox.SelectedIndex = FindFilmWithMaxRating(_films);
            _currentFilm = FilmBox.SelectedItem as Film;
        }

        /// <summary>
        /// Изменение значения названия фильма.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).Name = NameTextBox.Text;
                NameTextBox.BackColor = AppColors.BaseInput;

            }
            catch
            {
                NameTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение значения продолжительности фильма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).Duration = Convert.ToInt32(DurationTextBox.Text);
                DurationTextBox.BackColor = AppColors.BaseInput;

            }
            catch
            {
                DurationTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение значения года выпуска фильма.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).ReleaseYear = Convert.ToInt32(ReleaseYearTextBox.Text);
                ReleaseYearTextBox.BackColor = AppColors.BaseInput;

            }
            catch
            {
                ReleaseYearTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение значения жанра фильма.
        /// </summary>
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = AppColors.BaseInput;

            }
            catch
            {
                GenreTextBox.BackColor = AppColors.ErrorInput;
            }
        }

        /// <summary>
        /// Изменение значения рейтинга фильма.
        /// </summary>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).Rating = Convert.ToInt32(RatingTextBox.Text);
                RatingTextBox.BackColor = AppColors.BaseInput;

            }
            catch
            {
                RatingTextBox.BackColor = AppColors.ErrorInput;
            }
        }
    }
}
