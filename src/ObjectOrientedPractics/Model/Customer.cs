using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Interfaces;
using ObjectOrientedPractics.Model.Orders;
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
        private Address _address;

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders;

        /// <summary>
        /// Список скидок.
        /// </summary>
        private List<IDiscount> _discounts;

        /// <summary>
        /// Является ли покупатель приоритетным.
        /// </summary>
        private bool _isPriority = false;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="address">Адрес.</param>
        public Customer(string fullname, Address address)
        {
            _id = IdGenerator.GetNextId();
            FullName = fullname;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();

            if (!Discounts.Any(d => d is PointsDiscount))
            {
                Discounts.Add(new PointsDiscount());
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/> при десереализации.
        /// </summary>
        /// <param name="id">Идентификатор покупателя.</param>
        /// <param name="fullname">Полное имя.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="cart">Корзина.</param>
        /// <param name="orders">Заказы.</param>
        /// <param name="discounts">Скидки.</param>
        /// <param name="isPriority">Приоритетный покупатель.</param>
        [JsonConstructor]
        public Customer(int id, string fullname, Address address, Cart cart, List<Order> orders, List<IDiscount> discounts, bool isPriority = false)
        {
            _id = id;
            FullName = fullname;
            Address = address;
            Cart = cart ?? new Cart();
            Orders = orders ?? new List<Order>();
            IsPriority = isPriority;

            Discounts = discounts ?? new List<IDiscount>();

            if (!Discounts.Any(d => d is PointsDiscount))
            {
                Discounts.Add(new PointsDiscount());
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();

            if (!Discounts.Any(d => d is PointsDiscount))
            {
                Discounts.Add(new PointsDiscount());
            }
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
        public Address Address { get => _address; set => _address = value; }

        /// <summary>
        /// Корзина.
        /// </summary>
        public Cart Cart { get => _cart; set => _cart = value; }

        /// <summary>
        /// Список заказов.
        /// </summary>
        public List<Order> Orders { get => _orders; set => _orders = value; }

        /// <summary>
        /// Является ли покупатель приоритетным.
        /// </summary>
        public bool IsPriority { get => _isPriority; set => _isPriority = value; }

        /// <summary>
        /// Список скидок.
        /// </summary>
        [JsonProperty("Discounts")]
        public List<IDiscount> Discounts { get => _discounts; set => _discounts = value; }
        #endregion

        /// <summary>
        /// Метод переопределения ToString().
        /// </summary>
        /// <returns>Строку с информацией об покупателе.</returns>
        public override string ToString() => $"{FullName}";
    }
}