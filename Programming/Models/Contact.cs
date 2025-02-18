using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Models
{
    /// <summary>
    /// Контакт телефонной книжки.
    /// </summary>
    public class Contact
    {
        #region Fields
        /// <summary>
        /// Название.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surName;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="Name">Название.</param>
        /// <param name="SurName">Фамилия.</param>
        /// <param name="PhoneNumber">Номер телефона.</param>
        public Contact(string Name, string SurName, string PhoneNumber)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.PhoneNumber = PhoneNumber;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        #region Properties
        /// <summary>
        /// Название.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (Validator.AssertStringContainsOnlyLetters(value, nameof(Name)))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string SurName
        {
            get
            {
                return _surName;
            }
            set
            {
                if (Validator.AssertStringContainsOnlyLetters(value, nameof(SurName)))
                {
                    _surName = value;
                }
            }
        }

        /// <summary>
        /// Номер телефона.
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

    }
}
