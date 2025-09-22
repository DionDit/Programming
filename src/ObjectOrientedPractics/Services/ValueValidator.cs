using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Проверка определённых случаев.
    /// </summary>
    public static class ValueValidator
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
        /// Проверка на положительное вещественное значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Свойство передаваемого значения.</param>
        public static bool AssertOnPositiveValue(double value, string propertyName)
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

        /// <summary>
        /// Попадает ли вещественное значение в диапазон.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="min">Начало.</param>
        /// <param name="max">Конец.</param>
        /// <param name="propertyName">Свойство передаваемого значения.</param>
        public static bool AssertValueInRange(double value, double min, double max, string propertyName)
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

        /// <summary>
        /// Является ли одно значение больше другого.
        /// </summary>
        /// <param name="firstValue">Первое значение.</param>
        /// <param name="secondValue">Второе значение.</param>
        /// <param name="propertyName">Свойство передаваемого значения.</param>
        public static bool AssertValueMore(double firstValue, double secondValue, string propertyName)
        {
            if (firstValue > secondValue)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. Значение должно быть больше {secondValue}.");
            }
        }

        /// <summary>
        /// Является ли одно значение меньше другого.
        /// </summary>
        /// <param name="firstValue">Первое значение.</param>
        /// <param name="secondValue">Второе значение.</param>
        /// <param name="propertyName">Свойство передаваемого значения.</param>
        public static bool AssertValueLess(double firstValue, double secondValue, string propertyName)
        {
            if (firstValue < secondValue)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. Значение должно быть меньше {secondValue}.");
            }
        }

        /// <summary>
        /// Являются ли символы английского алфавита.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Свойство передаваемого значения.</param>
        public static bool AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. Значение не может быть пустым или состоять из пробелов.");
            }
            if (Regex.IsMatch(value, @"^[A-Za-z\s]+$"))
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"Некорректное значение в свойстве {propertyName}. Допустимы только английские буквы и пробелы.");
            }
        }

        /// <summary>
        /// Проверяет строку на длину.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="maxLength">Максимальная длина строки.</param>
        /// <param name="propertyName">Свойство передаваемого значения.</param>
        public static bool AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length <= maxLength)
            {
                return true;
            }
            else
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов!");
            }
        }

        /// <summary>
        /// Указание для ограничения ввода входных данных.
        /// </summary>
        public static void InterdictionInputData(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}