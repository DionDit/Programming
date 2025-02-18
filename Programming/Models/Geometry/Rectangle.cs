using Programming.Models.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    /// <summary>
    /// Прямоугольник.
    /// </summary>
    public class Rectangle
    {
        #region Fields
        /// <summary>
        /// Идентификатор прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Высота.
        /// </summary>
        private double _height;

        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width;

        /// <summary>
        /// Цвет.
        /// </summary>
        private string _color;

        /// <summary>
        /// Кол.во всех существующих прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="Center">Центр прямоугольника.</param>
        /// <param name="Height">Высота.</param>
        /// <param name="Width">Ширина.</param>
        /// <param name="Color">Цвет.</param>
        public Rectangle(Point2D Center, double Height, double Width, string Color)
        {
            this.Center = Center;
            this.Height = Height;
            this.Width = Width;
            this.Color = Color;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        #region Properties
        /// <summary>
        /// Идентификатор прямоугольника.
        /// </summary>
        public int Id { get => _id; }

        /// <summary>
        /// Центр прямоугольника.
        /// </summary>
        public Point2D Center { get; private set; }

        /// <summary>
        /// Длина.
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Height)))
                {
                    _height = value;
                }
            }
        }

        /// <summary>
        /// Ширина.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Width)))
                {
                    _width = value;
                }
            }
        }

        /// <summary>
        /// Цвет.
        /// </summary>
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _color = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение цвета");
                }
            }
        }

        /// <summary>
        /// Кол.во всех существующих прямоугольников.
        /// </summary>
        public static int AllRectanglesCount { get => _allRectanglesCount; }

        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        public static List<Rectangle> Rectangles = new List<Rectangle>();
        #endregion

        /// <summary>
        /// Метод переопределения ToString().
        /// </summary>
        /// <returns>Строку с информацией об прямоугольнике.</returns>
        public override string ToString() => $"{Id}: (X= {Center.X}; Y= {Center.Y}; W= {Width}; H= {Height})";
    }
}
