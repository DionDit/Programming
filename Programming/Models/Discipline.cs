using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Discipline
    {
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private string _teacherLastName;

		public string TeacherLastName
        {
			get { return _teacherLastName; }
			set { _teacherLastName = value; }
		}

		private int _assessment;

        public int Assessment
        {
			get { return _assessment; }
			set { _assessment = value; }
		}

	}
}
