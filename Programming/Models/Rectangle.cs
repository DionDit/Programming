using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Rectangle
    {
		private double _lenght;

		public double Lenght
		{
			get { return _lenght; }
			set { _lenght = value; }
		}
		private double _width;

		public double Width
		{
			get { return _width; }
			set { _width = value; }
		}

		private string _color;

		public string Color
		{
			get { return _color; }
			set { _color = value; }
		}



	}
}
