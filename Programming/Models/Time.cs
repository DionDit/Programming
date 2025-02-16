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
        public Time(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public Time()
        {

        }
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
                if (Validator.AssertValueInRange(value, 0, 23, nameof(Hours)))
                {
                    _hours = value;
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
                if (Validator.AssertValueInRange(value, 0, 60, nameof(Minutes)))
                {
                    _minutes = value;
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
                if (Validator.AssertValueInRange(value, 0, 60, nameof(Seconds)))
                {
                    _seconds = value;
                }
            }
        }
        #endregion
    }
}
