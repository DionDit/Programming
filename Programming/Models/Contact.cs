using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Contact
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		private string _phoneNumber;

		public string PhoneNumber
		{
			get { return _phoneNumber; }
			set { _phoneNumber = value; }
		}

	}
}
