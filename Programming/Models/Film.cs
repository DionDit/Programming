using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Film
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _duration;

		public int Duration
		{
			get { return _duration; }
			set { _duration = value; }
		}

		private int _releaseYear;

		public int ReleaseYear
		{
			get { return _releaseYear; }
			set { _releaseYear = value; }
		}

		private string _genre;

		public string Genre
        {
			get { return _genre; }
			set { _genre = value; }
		}

		private double _rating;

		public double Rating
        {
			get { return _rating; }
			set { _rating = value; }
		}


	}
}
