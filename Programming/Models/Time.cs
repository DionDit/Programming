using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Time
    {
		private int _hours;

		public int Hours
		{
			get { return _hours; }
			set { _hours = value; }
		}

		private int _minutes;

		public int Minutes
		{
			get { return _minutes; }
			set { _minutes = value; }
		}

		private int _seconds;

		public int Seconds
		{
			get { return _seconds; }
			set { _seconds = value; }
		}


	}
}
