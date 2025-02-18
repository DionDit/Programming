using Programming.Models.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Rectangle
    {
        #region Fields
        /// <summary>
        /// Индетификатор прямоугольника
        /// </summary>
        private int _id;
        /// <summary>
        /// Высота
        /// </summary>
        private double _height;
        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;
        /// <summary>
        /// Цвет
        /// </summary>
        private string _color;
        /// <summary>
        /// Кол.во всех существующих прямоугольников
        /// </summary>
        private static int _allRectanglesCount;
        #endregion
        public Rectangle(Point2D Center, double Height, double Width, string Color)
        {
            this.Center = Center;
            this.Height = Height;
            this.Width = Width;
            this.Color = Color;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
        #region Properties
        public int Id { get => _id; }
        /// <summary>
        /// Центр прямоугольника
        /// </summary>
        //public Point2D Center { get => new Point2D(Width / 3, Height / 2); }
        public Point2D Center { get; private set; }
        /// <summary>
        /// Длина
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
        /// Ширина
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
        /// Цвет
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
        public static int AllRectanglesCount { get => _allRectanglesCount; }
        public static List<Rectangle> Rectangles = new List<Rectangle>();
        #endregion

        public override string ToString() => $"{Id}: (X= {Center.X}; Y= {Center.Y}; W= {Width}; H= {Height})";
    }
}
