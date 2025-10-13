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
    public class Cart
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
    }
}