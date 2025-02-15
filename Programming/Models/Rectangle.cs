using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Rectangle
    {
        public Rectangle(int Index, double Lenght, double Width, string Color)
        {
            this.Index = Index;
            this.Lenght = Lenght;
            this.Width = Width;
            this.Color = Color;
        }
        public Rectangle()
        {

        }
        #region Fields
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
        #endregion

        #region Properties
        public int Index { get; set; }
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
                if (value > 0)
                {
                    _lenght = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение длины");
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
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение ширины");
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
        #endregion

        public override string ToString() => $"Rectangle {Index}";
    }
}
