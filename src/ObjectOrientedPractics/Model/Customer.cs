using Newtonsoft.Json;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель
    /// </summary>
    public class Customer
    {
        #region Fields
        /// <summary>
        /// Идентификатор покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес.
        /// </summary>
        private string _address;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="address">Адрес.</param>
        public Customer(string fullname, string address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullname;
            Address = address;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/> при десереализации.
        /// </summary>
        /// <param name="id">Идентификатор покупателя.</param>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="address">Адрес.</param>
        [JsonConstructor]
        public Customer(int id, string fullname, string address)
        {
            _id = id;
            FullName = fullname;
            Address = address;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
        }

        #region Properties
        /// <summary>
        /// Идентификатор покупателя.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Полное имя.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, nameof(FullName)))
                {
                    _fullname = value;
                }
            }
        }

        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 500, nameof(Address)))
                {
                    _address = value;
                }
            }
        }
        #endregion

        /// <summary>
        /// Метод переопределения ToString().
        /// </summary>
        /// <returns>Строку с информацией об покупателе.</returns>
        public override string ToString() => $"{Id}| {FullName}";
    }
}