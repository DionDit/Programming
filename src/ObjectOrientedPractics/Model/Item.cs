using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using ValueValidator = ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    [Serializable]
    public class Item
    {
        #region Fields
        /// <summary>
        /// Идентификатор предмета.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название предмета.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о предмете.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость предмета.
        /// </summary>
        private double _cost;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название предмета.</param>
        /// <param name="info">Информация о предмете.</param>
        /// <param name="cost">Стоимость предмета.</param>
        /// <param name="category">Категория предмета.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Information = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/> при десереализации.
        /// </summary>
        /// <param name="id">Идентификатор предмета.</param>
        /// <param name="name">Название предмета.</param>
        /// <param name="info">Информация о предмете.</param>
        /// <param name="cost">Стоимость предмета.</param>
        /// <param name="category">Категория предмета.</param>
        [JsonConstructor]
        private Item(int id, string name, string info, double cost, Category category)
        {
            _id = id;
            _name = name;
            _info = info;
            _cost = cost;
            Category = category;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
        }

        #region Properties
        /// <summary>
        /// Идентификатор предмета.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Название предмета.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 200, nameof(Name)))
                {
                    _name = value;
                }
            }
        }

        /// <summary>
        /// Информация о предмете.
        /// </summary>
        public string Information
        {
            get
            {
                return _info;
            }
            set
            {
                if (ValueValidator.AssertStringOnLength(value, 1000, nameof(Information)))
                {
                    _info = value;
                }
            }
        }

        /// <summary>
        /// Стоимость предмета.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost)))
                {
                    _cost = value;
                }
            }
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }
        #endregion

        /// <summary>
        /// Метод переопределения ToString().
        /// </summary>
        /// <returns>Строку с информацией об предмете.</returns>
        public override string ToString() => $"{Id}| {Name}";
    }
}