using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    public class Contact
    {
        #region Fields
        /// <summary>
        /// Название
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия
        /// </summary>
        private string _lastName;
        /// <summary>
        /// Номер телефона
        /// </summary>
        private string _phoneNumber;

        #endregion

        #region Properties
        /// <summary>
        /// Название
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение имени");
                }
            }
        }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение фамилии");
                }
            }
        }
        /// <summary>
        /// Номер телефона
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length == 11)
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение номера телефона");
                }
            }
        }
        #endregion

        public Contact(string Name, string LastName, string PhoneNumber)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
        }
        public Contact()
        {
            
        }
    }
}
