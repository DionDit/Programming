using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PriorityOrder : Order
    {
        #region Fields
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        [JsonProperty]
        private DateTime _deliveryDate;

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        [JsonProperty]
        private string _deliveryTime;
        #endregion

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="PriorityOrder"/> с указанными адресом и товарами.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="items"></param>
        public PriorityOrder(Address address, List<Item> items) : base(address, items)
        {
        }

        /// <summary>
        /// Конструктор для десериализации JSON.
        /// </summary>
        [JsonConstructor]
        private PriorityOrder(int id, DateTime creationDate, Address address,List<Item> items, OrderStatus orderStatus,DateTime deliveryDate, string deliveryTime) 
                             : base(id, creationDate, address, items, orderStatus)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }

        #region Properties
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        public DateTime DeliveryDate
        {
            get => _deliveryDate;
            set => _deliveryDate = value; 
        }

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        public string DeliveryTime
        {
            get => _deliveryTime;
            set => _deliveryTime = value;
        }
        #endregion
    }
}