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
    public class Order
    {
        #region Fields
        /// <summary>
        /// Идентификатор заказа.
        /// </summary>
        private readonly int _id;

        private readonly DateTime _creationDate;

        private Address _address;

        private List<Item> _items;

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
        private Order(int id, DateTime creationDate, Address address, List<Item> items, OrderStatus orderStatus)
        {
            _id = id;
            _creationDate = creationDate;
            Address = address;
            Items = items;
            OrderStatus = orderStatus;
        }



        #region Properties
        public int Id => _id;

        public DateTime CreationDate => _creationDate;

        public Address Address { get => _address; set => _address = value; }

        public List<Item> Items { get => _items; set => _items = value; }

        public OrderStatus OrderStatus { get; set; }

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
