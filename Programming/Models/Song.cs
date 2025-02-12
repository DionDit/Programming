using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Song
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _artist;

        public string Фrtist
        {
			get { return _artist; }
			set { _artist = value; }
		}

		private double _duration;

		public double Duration
		{
			get { return _duration; }
			set { _duration = value; }
		}


	}
}
