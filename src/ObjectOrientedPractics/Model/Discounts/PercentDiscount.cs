using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    [Serializable]
    [JsonObject]
    public class PercentDiscount : IDiscount
    {
        #region Fields
        /// <summary>
        /// Процент скидки (от 1% до 10%).
        /// </summary>
        private int _discountPercent;

        /// <summary>
        /// Сумма покупок по категории скидки.
        /// </summary>
        private double _purchaseAmount;

        /// <summary>
        /// Возвращает категорию товаров, на которую предоставляется скидка.
        /// </summary>
        private Category _category;
        #endregion

        /// <summary>
        /// Конструктор класса <see cref="PercentDiscount"/> для указанной категории.
        /// </summary>
        /// <param name="category">Категория товаров для скидки.</param>
        public PercentDiscount(Category category)
        {
            _category = category;
            DiscountPercent = 1;
            PurchaseAmount = 0;
        }

        public PercentDiscount()
        {
        }

        #region Properties
        /// <summary>
        /// Процент скидки (от 1% до 10%).
        /// </summary>
        public int DiscountPercent
        {
            get => _discountPercent;
            set => _discountPercent = Math.Clamp(value, 1, 10);
        }

        /// <summary>
        /// Сумма покупок по категории скидки.
        /// </summary>
        public double PurchaseAmount
        {
            get => _purchaseAmount;
            set => _purchaseAmount = value;
        }

        /// <summary>
        /// Возвращает категорию товаров, на которую предоставляется скидка.
        /// </summary>
        public Category Category { get => _category; set => _category = value; }

        /// <summary>
        /// Строка с информацией о скидке.
        /// </summary>
        [JsonIgnore]
        public string Info => $"Процентная «{Category.GetDisplayName()}» - {DiscountPercent}%";
        #endregion

        /// <summary>
        /// Вычисляет размер скидки для списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки в рублях.</returns>
        public double Calculate(List<Item> items)
        {
            if (items == null || !items.Any())
            {
                return 0;
            }

            double categoryAmount = items.Where(item => item.Category == Category).Sum(item => item.Cost);

            return categoryAmount * (DiscountPercent / 100.0);
        }

        /// <summary>
        /// Применяет скидку к списку товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки в рублях.</returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Обновляет процент скидки на основе новых покупок.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            if (items == null || !items.Any())
            {
                return;
            }

            double categoryAmount = items.Where(item => item.Category == Category).Sum(item => item.Cost);
            PurchaseAmount += categoryAmount;
            DiscountPercent = 1 + (int)(PurchaseAmount / 1000);
        }

        public override string ToString() => Info;
    }
}