using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Time
    {
        #region Fields
        /// <summary>
        /// Часы
        /// </summary>
        private int _hours;
        /// <summary>
        /// Минуты
        /// </summary>
        private int _minutes;
        /// <summary>
        /// Секунды
        /// </summary>
        private int _seconds;

        #endregion

        #region Properties
        /// <summary>
        /// Часы
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value > 0 && value <= 23)
                {
                    _hours = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение часов");
                }
            }
        }
        /// <summary>
        /// Минуты
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value > 0 && value <= 60)
                {
                    _minutes = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение минут");
                }
            }
        }
        /// <summary>
        /// Секунды
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value > 0 && value <= 60)
                {
                    _seconds = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение минут");
                }
            }
        }
        #endregion

        public Time(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public Time()
        {
            
        }
    }
}
