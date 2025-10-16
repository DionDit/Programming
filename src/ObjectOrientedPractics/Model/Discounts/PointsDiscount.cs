using Newtonsoft.Json;
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
    public class PointsDiscount : IDiscount
    {
        #region Fields
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        private int _pointsCount;
        #endregion

        public PointsDiscount()
        {
        }

        public PointsDiscount(int pointsCount)
        {
            PointsCount = pointsCount;
        }

        #region Properties
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        public int PointsCount { get => _pointsCount; set => _pointsCount = value; }

        /// <summary>
        /// Cтрока с информацией о скидке.
        /// </summary>
        [JsonIgnore]
        public string Info => $"Накопительная – {PointsCount} баллов";

        #endregion

        /// <summary>
        /// Вычисляет общую стоимость товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Общая стоимость товаров.</returns>
        private double CalculateAmount(List<Item> items) => items.Sum(x => x.Cost);

        /// <summary>
        /// Вычисляет размер доступной скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки в рублях.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = CalculateAmount(items);
            double maxDiscount = amount * 0.3;

            return Math.Min(PointsCount, maxDiscount);
        }

        /// <summary>
        /// Применяет скидку и списывает баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер примененной скидки.</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);
            PointsCount -= (int)discount;
            return discount;
        }

        public void Update(List<Item> items)
        {
            double amount = CalculateAmount(items);
            double pointsToAdd = amount * 0.1;

            int roundedPoints = (int)Math.Ceiling(pointsToAdd);

            PointsCount += roundedPoints;
        }

        public override string ToString() => Info;
    }
}