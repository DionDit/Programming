using Programming.Models;
using Programming.Models.Enums;
using Programming.Models.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Models.Rectangle;

namespace Programming.Views.Forms
{
    public partial class MainForm : Form
    {
        #region Fields
        private List<Rectangle> _rectangles;
        private Rectangle _currentRectangle;

        private List<Film> _films;
        private Film _currentFilm;
        #endregion
        public MainForm()
        {
            InitializeComponent();
            Random rnd = new Random();
            _rectangles = new List<Rectangle>();
            _films = new List<Film>();
            for (int i = 0; i < 5; i++)
            {
                _rectangles.Add(new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10), "Black"));
                _films.Add(new Film($"Film", rnd.Next(1, 4), rnd.Next(1980, 2025), "Horror", Convert.ToDouble(rnd.Next(1, 11))));

            }
            RectanglesBox.DataSource = _rectangles;
            FilmBox.DataSource = _films;
            FilmBox.SelectedIndex = 0;
            FilmBox.DisplayMember = "Name";
            RectanglesBox.SelectedIndex = 0;
            SeasonCB.DataSource = Enum.GetValues(typeof(Season));
        }
        #region Enum Page
        private void EnumListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch ((sender as ListBox).SelectedIndex)
            {
                case 0:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Models.Enums.Color));
                    break;
                case 1:
                    ValueListBox.DataSource = Enum.GetValues(typeof(FormStudyStudent));
                    break;
                case 2:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case 3:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                case 4:
                    ValueListBox.DataSource = Enum.GetValues(typeof(SmartphoneManufacturers));
                    break;
                case 5:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }
        private void ValueListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            EnumValue.Text = Convert.ToInt32(ValueListBox.SelectedValue).ToString();
        }
        private void WeekDayParseButtonClick(object sender, EventArgs e)
        {
            Weekday OutPut;
            if (Enum.TryParse(WeekDayTextBox.Text, true, out OutPut))
            {
                WeekDayText.Text = $"Это день недели ({OutPut} = {Convert.ToInt32(OutPut)})";
            }
            else
            {
                WeekDayText.Text = $"Нет такого дня недели!";
            }
        }
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonCB.SelectedIndex)
            {
                case 0:
                    BackColor = System.Drawing.Color.Yellow;
                    MessageBox.Show("Ура! Солнце!", "Лето", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 1:
                    BackColor = System.Drawing.Color.Orange;
                    MessageBox.Show("О нет! Листья падают!", "Осень", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    BackColor = System.Drawing.Color.Blue;
                    MessageBox.Show("Бррр! Холодно!", "Зима", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 3:
                    BackColor = System.Drawing.Color.Green;
                    MessageBox.Show("Ураа! Птички вернулись!", "Весна", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
        #endregion
        #region Rectangle Page
        private void RectanglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = RectanglesBox.SelectedItem as Rectangle;
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            LenghtTextBox.Text = _currentRectangle.Lenght.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }
        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (RectanglesBox.SelectedItem as Rectangle).Lenght = Convert.ToInt32(LenghtTextBox.Text);
                LenghtTextBox.BackColor = System.Drawing.Color.White;

            }
            catch
            {
                LenghtTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (RectanglesBox.SelectedItem as Rectangle).Width = Convert.ToInt32(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;

            }
            catch
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((Models.Enums.Color)Enum.Parse(typeof(Models.Enums.Color), ColorTextBox.Text) != null)
                {
                    (RectanglesBox.SelectedItem as Rectangle).Color = ColorTextBox.Text;
                    ColorTextBox.BackColor = System.Drawing.Color.White;
                }
            }
            catch
            {
                ColorTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private int FindRectangleWithMaxWidth(List<Rectangle> Rectangles)
        {
            double maxWidth = 0;
            int Index = 0;
            for (int i = 0; i < Rectangles.Count; i++)
            {
                if (Rectangles[i].Width > maxWidth)
                {
                    maxWidth = Rectangles[i].Width;
                    Index = i;
                }
            }
            return Index;
        }
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
            _currentRectangle = RectanglesBox.SelectedItem as Rectangle;
        }
        private void XTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void YTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        #endregion
        #region Film Page
        private void FilmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = FilmBox.SelectedItem as Film;
            NameTextBox.Text = _currentFilm.Name;
            DurationTextBox.Text = _currentFilm.Duration.ToString();
            ReleaseYearTextBox.Text = _currentFilm.ReleaseYear.ToString();
            GenreTextBox.Text = _currentFilm.Genre.ToString();
            RatingTextBox.Text = _currentFilm.Rating.ToString();
        }
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
        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            FilmBox.SelectedIndex = FindFilmWithMaxRating(_films);
            _currentFilm = FilmBox.SelectedItem as Film;
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).Name = NameTextBox.Text;
                NameTextBox.BackColor = System.Drawing.Color.White;

            }
            catch
            {
                NameTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).Duration = Convert.ToInt32(DurationTextBox.Text);
                DurationTextBox.BackColor = System.Drawing.Color.White;

            }
            catch
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).ReleaseYear = Convert.ToInt32(ReleaseYearTextBox.Text);
                ReleaseYearTextBox.BackColor = System.Drawing.Color.White;

            }
            catch
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).Genre = GenreTextBox.Text;
                GenreTextBox.BackColor = System.Drawing.Color.White;

            }
            catch
            {
                GenreTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                (FilmBox.SelectedItem as Film).Rating = Convert.ToInt32(RatingTextBox.Text);
                RatingTextBox.BackColor = System.Drawing.Color.White;

            }
            catch
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        #endregion
    }
}
