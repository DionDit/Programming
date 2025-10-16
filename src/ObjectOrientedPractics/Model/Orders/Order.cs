using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model.Orders
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Order : IEquatable<Order>
    {
        #region Fields
        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        [JsonProperty]
        private readonly int _id;

        /// <summary>
        /// Дата создания.
        /// </summary>
        [JsonProperty]
        private readonly DateTime _creationDate;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        [JsonProperty]
        private Address _address;

        /// <summary>
        /// Товары.
        /// </summary>
        [JsonProperty]
        private List<Item> _items;

        /// <summary>
        /// Статус заказа.
        /// </summary>
        [JsonProperty]
        private OrderStatus _orderStatus { get; set; }

        /// <summary>
        /// Размер примененной скидки.
        /// </summary>
        private double _discountAmount;

        /// <summary>
        /// Конечная стоимость заказа.
        /// </summary>
        private double _totalAmount;
        #endregion

        public Order(Address address, List<Item> items)
        {
            _id = IdGenerator.GetNextId();
            _creationDate = DateTime.Now;
            Address = address;
            Items = items.ToList();
            OrderStatus = OrderStatus.New;
        }

        [JsonConstructor]
        public Order(int id, DateTime creationDate, Address address, List<Item> items, OrderStatus orderStatus, double discountAmount)
        {
            _id = id;
            _creationDate = creationDate;
            Address = address;
            Items = items;
            OrderStatus = orderStatus;
            DiscountAmount = discountAmount;
        }

        #region Properties
        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Дата создания.
        /// </summary>
        public DateTime CreationDate => _creationDate;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        public Address Address { get => _address; set => _address = value; }

        /// <summary>
        /// Товары.
        /// </summary>
        public List<Item> Items { get => _items; set => _items = value; }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get => _orderStatus; set => _orderStatus = value; }

        /// <summary>
        /// Имя покупателя (для отображения)
        /// </summary>
        [JsonIgnore]
        public string CustomerName => AppData.Customers.FirstOrDefault(x => x.Orders.Contains(this)).FullName;

        /// <summary>
        /// Адрес в виде строки (для отображения)
        /// </summary>
        [JsonIgnore]
        public string AddressString => $"{Address.Index}, {Address.Country}, г.{Address.City}, ул.{Address.Street}, {Address.Building}, кв.{Address.Apartment}";

        /// <summary>
        /// Общая стоимость всех товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items.Count != 0 || Items != null)
                {
                    return Items.Sum(x => x.Cost);
                }
                else
                {
                    return 0.0;
                }
            }
        }

        /// <summary>
        /// Размер примененной скидки.
        /// </summary>
        [JsonProperty]
        public double DiscountAmount { get => _discountAmount; set => _discountAmount = value; }

        /// <summary>
        /// Конечная стоимость заказа.
        /// </summary>
        public double TotalAmount 
        { 
            get 
            {
                double total = Amount - DiscountAmount;
                return total >= 0 ? total : 0;
            } 
        }
        #endregion

        /// <summary>
        /// Определяет, равен ли указанный объект текущему объекту.
        /// </summary>
        /// <param name="other">Объект для сравнения с текущим объектом.</param>
        public bool Equals(Order other)
        {
            if (other is null)
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return _id == other._id &&
                   _creationDate == other._creationDate &&
                   Equals(_address, other._address) &&
                   OrderStatus == other.OrderStatus &&
                   _discountAmount == other._discountAmount &&
                   ItemsEqual(_items, other._items);
        }

        /// <summary>
        /// Определяет, равен ли указанный объект текущему объекту.
        /// </summary>
        /// <param name="obj">Объект для сравнения с текущим объектом.</param>
        public override bool Equals(object obj)
        {
            return Equals(obj as Order);
        }

        /// <summary>
        /// Сравнивает два списка товаров на равенство.
        /// </summary>
        /// <param name="first">Первый список товаров.</param>
        /// <param name="second">Второй список товаров.</param>
        private bool ItemsEqual(List<Item> first, List<Item> second)
        {
            if (first == null && second == null)
            {
                return true;
            }
            if (first == null || second == null)
            {
                return false;
            }
            if (first.Count != second.Count)
            {
                return false;
            }

            return first.SequenceEqual(second);
        }
    }
}