using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
	/// <summary>
	/// Корзина.
	/// </summary>
    public class Cart : ICloneable
    {
        #region Fields
		/// <summary>
		/// Список товаров.
		/// </summary>
        private List<Item> _items = new List<Item>();
        #endregion

        #region Properties
        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Общая стоимость всех товаров в корзине.
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

        /// <summary>
        /// Создает копию объекта <see cref="Cart"/>.
        /// </summary>
        /// <returns>Новый объект <see cref="Cart"/> с копиями товаров.</returns>
        public object Clone()
        {
            var clonedCart = new Cart();
            if (_items != null)
            {
                clonedCart._items = _items.Select(item => (Item)item.Clone()).ToList();
            }
            return clonedCart;
        }
    }
}