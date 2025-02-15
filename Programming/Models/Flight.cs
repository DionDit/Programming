using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Flight
    {
        #region Fields
        /// <summary>
        /// Пункт вылета
        /// </summary>
        private string _departurePoint;
        /// <summary>
        /// Пункт назначения
        /// </summary>
        private string _destination;
        /// <summary>
        ///  Время полета в минутах
        /// </summary>
        private int _flightTime;
        #endregion

        #region Properties
        /// <summary>
        /// Пункт вылета
        /// </summary>
        public string DeparturePoint
        {
            get
            {
                return _departurePoint;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _departurePoint = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение пункта вылета");
                }
            }
        }
        /// <summary>
        /// Пункт назначения
        /// </summary>
        public string Destination
        {
            get
            {
                return _destination;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _destination = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение пункта назначения");
                }
            }
        }
        /// <summary>
        ///  Время полета в минутах
        /// </summary>
        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                if (value > 0)
                {
                    _flightTime = value;
                }
                else
                {
                    throw new ArgumentException("Недопустимое значение времени полета");
                }
            }
        }
        #endregion

        public Flight(string DeparturePoint, string Destination, int FlightTime)
        {
            this.DeparturePoint = DeparturePoint;
            this.Destination = Destination;
            this.FlightTime = FlightTime;
        }
        public Flight()
        {
            
        }
    }
}
