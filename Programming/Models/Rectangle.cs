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
        // Длина
        private double _lenght;
        //Ширина
        private double _width;
        //Цвет
        private string _color;
        #endregion

        #region Properties
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
    }
}
