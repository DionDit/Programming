using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Flight
    {
		private string _departurePoint;

		public string DeparturePoint
		{
			get { return _departurePoint; }
			set { _departurePoint = value; }
		}

		private string _destination;

		public string Destination
        {
			get { return _destination; }
			set { _destination = value; }
		}

		private int _flightTime;

		public int FlightTime
		{
			get { return _flightTime; }
			set { _flightTime = value; }
		}

	}
}
