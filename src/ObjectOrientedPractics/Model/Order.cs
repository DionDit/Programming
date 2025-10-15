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

namespace ObjectOrientedPractics.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Order
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
        public Order(int id, DateTime creationDate, Address address, List<Item> items, OrderStatus orderStatus)
        {
            _id = id;
            _creationDate = creationDate;
            Address = address;
            Items = items;
            OrderStatus = orderStatus;
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
        #endregion
    }
}