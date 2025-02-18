using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    /// <summary>
    /// Информация о полете
    /// </summary>
    public class Flight
    {
        #region Fields
        /// <summary>
        /// Пункт вылета.
        /// </summary>
        private string _departurePoint;

        /// <summary>
        /// Пункт назначения.
        /// </summary>
        private string _destination;

        /// <summary>
        ///  Время полета в минутах.
        /// </summary>
        private int _flightTime;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="DeparturePoint">Пункт вылета.</param>
        /// <param name="Destination">Пункт назначения.</param>
        /// <param name="FlightTime">Время полета.</param>
        public Flight(string DeparturePoint, string Destination, int FlightTime)
        {
            this.DeparturePoint = DeparturePoint;
            this.Destination = Destination;
            this.FlightTime = FlightTime;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {

        }

        #region Properties
        /// <summary>
        /// Пункт вылета.
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
        /// Пункт назначения.
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
        ///  Время полета в минутах.
        /// </summary>
        public int FlightTime
        {
            get
            {
                return _flightTime;
            }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(FlightTime)))
                {
                    _flightTime = value;
                }
            }
        }
        #endregion
    }
}
