using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using ValueValidator = ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    [Serializable]
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
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

        #region Events
        /// <summary>
        /// Событие, возникающее при изменении названия товара.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Событие, возникающее при изменении стоимости товара.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Событие, возникающее при изменении описания товара.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;
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
                    OnNameChanged(EventArgs.Empty);
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
                    OnInfoChanged(EventArgs.Empty);
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
                    OnCostChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }
        #endregion

        /// <summary>
        /// Создает копию объекта <see cref="Item"/>.
        /// </summary>
        public object Clone()
        {
            return new Item(_name, _info, _cost, Category);
        }

        /// <summary>
        /// Определяет, равен ли указанный объект текущему объекту.
        /// </summary>
        /// <param name="other">Объект для сравнения с текущим объектом.</param>
        public bool Equals(Item other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return _id == other._id && _name == other._name && _info == other._info &&
                   _cost == other._cost && Category == other.Category;
        }

        /// <summary>
        /// Определяет, равен ли указанный объект текущему объекту.
        /// </summary>
        /// <param name="obj">Объект для сравнения с текущим объектом.</param>
        public override bool Equals(object obj)
        {
            return Equals(obj as Item);
        }

        /// <summary>
        /// Сравнивает текущий объект с другим объектом <see cref="Item"/> по стоимости.
        /// </summary>
        /// <param name="other">Объект для сравнения с текущим объектом.</param>
        public int CompareTo(Item other)
        {
            if (other is null)
            {
                return 1;
            }

            return _cost.CompareTo(other._cost);
        }

        /// <summary>
        /// Вызывает событие NameChanged.
        /// </summary>
        protected virtual void OnNameChanged(EventArgs e) => NameChanged?.Invoke(this, e);

        /// <summary>
        /// Вызывает событие CostChanged.
        /// </summary>
        protected virtual void OnCostChanged(EventArgs e) => CostChanged?.Invoke(this, e);

        /// <summary>
        /// Вызывает событие InfoChanged.
        /// </summary>
        protected virtual void OnInfoChanged(EventArgs e) => InfoChanged?.Invoke(this, e);

        /// <summary>
        /// Метод переопределения ToString().
        /// </summary>
        /// <returns>Строку с информацией об предмете.</returns>
        public override string ToString() => $"{Name}";
    }
}