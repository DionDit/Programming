using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Interfaces
{
    [JsonObject]
    public interface IDiscount
    {
        /// <summary>
        /// Строка с информацией о скидке.
        /// </summary>
        [JsonIgnore]
        string Info { get; }

        /// <summary>
        /// Вычисляет размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}