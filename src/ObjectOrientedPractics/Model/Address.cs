using Newtonsoft.Json;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
	/// <summary>
	/// Адрес покупателя.
	/// </summary>
    public class Address
    {
        #region Fields
        /// <summary>
        /// Индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;
        #endregion

        [JsonConstructor]
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        public Address()
        {
            
        }

        #region Properties
        /// <summary>
        /// Индекс.
        /// </summary>
        public int Index
        {
            get => _index;
            set
            {
                if (ValueValidator.AssertValueInRange(value, 111111, 999999, nameof(Index)))
                {
                    _index = value;
                }
            }
        }

        /// <summary>
        /// Страна.
        /// </summary>
        public string Country
        {
            get => _country;
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, nameof(Country)))
                {
                    _country = value;
                }
            }
        }

        /// <summary>
        /// Город.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 50, nameof(City)))
                {
                    _city = value;
                }
            }
        }

        /// <summary>
        /// Улица.
        /// </summary>
        public string Street
        {
            get => _street;
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 100, nameof(Street)))
                {
                    _street = value;
                }
            }
        }

        /// <summary>
        /// Номер дома.
        /// </summary>
        public string Building
        {
            get => _building;
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, nameof(Building)))
                {
                    _building = value;
                }
            }
        }

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        public string Apartment
        {
            get => _apartment;
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment)))
                {
                    _apartment = value;
                }
            }
        }

        /// <summary>
        /// Получает значение, указывающее, заполнены ли все поля адреса.
        /// </summary>
        public bool IsFullyFilled =>
        !string.IsNullOrWhiteSpace(Country) &&
        !string.IsNullOrWhiteSpace(City) &&
        !string.IsNullOrWhiteSpace(Street) &&
        !string.IsNullOrWhiteSpace(Building) &&
        !string.IsNullOrWhiteSpace(Apartment) &&
        Index >= 100000 && Index <= 999999;
        #endregion


    }
}