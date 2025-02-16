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
        /// Длина
        /// </summary>
        private double _lenght;
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
        public Rectangle(double Lenght, double Width, string Color)
        {
            this.Lenght = Lenght;
            this.Width = Width;
            this.Color = Color;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
        public Rectangle()
        {

        }
        #region Properties
        public int Id { get => _id; }
        /// <summary>
        /// Центр прямоугольника
        /// </summary>
        public Point2D Center { get => new Point2D(Width / 2, Lenght / 2); }
        /// <summary>
        /// Длина
        /// </summary>
        public double Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Lenght)))
                {
                    _lenght = value;
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
        #endregion

        public override string ToString() => $"Rectangle {Id}";
    }
}
