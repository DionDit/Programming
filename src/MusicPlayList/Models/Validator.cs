using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Models
{
    /// <summary>
    /// Проверка определённых случаев.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверка на положительное целочисленного значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Свойство передаваемого значения.</param>
        public static bool AssertOnPositiveValue(int value, string propertyName)
        {
            if (value > 0)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. Значение должно быть положительным.");
            }
        }


        /// <summary>
        /// Попадает ли целочисленное значение в диапазон.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Начало.</param>
        /// <param name="max">Конец.</param>
        /// <param name="propertyName">Свойство передаваемого значения.</param>
        public static bool AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value >= min && value <= max)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. Значение должно быть в диапазоне от {min} до {max}.");
            }
        }

    }
}