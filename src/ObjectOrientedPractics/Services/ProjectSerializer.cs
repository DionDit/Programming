using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Interfaces;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для работы с json.
    /// </summary>
    public static class ProjectSerializer
    {
        private static FormClosingEventHandler _autoSaveHandler;

        /// <summary>
        /// Путь хранения данных приложения.
        /// </summary>
        private static readonly string _filePath = "data.json";

        /// <summary>
        /// Настройки сериализатора.
        /// </summary>
        private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            TypeNameHandling = TypeNameHandling.All,
            NullValueHandling = NullValueHandling.Ignore
        };

        /// <summary>
        /// Сохранение всех данных.
        /// </summary>
        /// <param name="data">Данные для сохранения</param>
        public static void SaveData(object data)
        {
            try
            {
                string json = JsonConvert.SerializeObject(data, _serializerSettings);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Загрузка данных из системного файла.
        /// </summary>
        public static void LoadData()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    return;
                }

                string json = File.ReadAllText(_filePath);

                var container = JsonConvert.DeserializeObject<AppDataContainer>(json, _serializerSettings);

                if (container != null)
                {
                    AppData.IsExitSaving = container.IsExitSaving;
                    AppData.Items = container.Items ?? new List<Item>();
                    AppData.Customers = container.Customers ?? new List<Customer>();

                    FixItemReferences();
                    FixDiscountReferences();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppData.Items = new List<Item>();
                AppData.Customers = new List<Customer>();
            }
        }

        /// <summary>
        /// Исправляет ссылки на товары в корзинах и заказах
        /// </summary>
        private static void FixItemReferences()
        {
            // Базовые проверки
            if (AppData.Items == null || AppData.Customers == null)
            {
                return;
            }

            var itemMap = AppData.Items.ToDictionary(x => x.Id);

            foreach (var customer in AppData.Customers.Where(c => c != null))
            {
                customer.Cart ??= new Cart();
                customer.Cart.Items = customer.Cart.Items?
                        .Where(item => item != null && itemMap.ContainsKey(item.Id))
                        .Select(item => itemMap[item.Id])
                        .ToList() ?? new List<Item>();

                customer.Orders?.ForEach(order =>
                {
                    order.Items = order.Items?
                         .Where(item => item != null && itemMap.ContainsKey(item.Id))
                         .Select(item => itemMap[item.Id])
                         .ToList() ?? new List<Item>();
                });
            }
        }

        /// <summary>
        /// Восстанавливает ссылки на скидки после десериализации
        /// </summary>
        private static void FixDiscountReferences()
        {
            foreach (var customer in AppData.Customers)
            {
                if (customer?.Discounts == null) 
                {
                    continue;
                }
                customer.Discounts = customer.Discounts.Where(d => d != null).ToList();
            }
        }

        /// <summary>
        /// Автоматическое сохранение при закрытии приложения.
        /// </summary>
        /// <param name="mainForm">Форма при закрытии которой будут сохраняться системный файл.</param>
        public static void EnableAutoSave(Form mainForm)
        {
            DisableAutoSave(mainForm);

            _autoSaveHandler = (s, e) =>
            {
                if (AppData.IsExitSaving)
                {
                    var container = new AppDataContainer
                    {
                        Items = AppData.Items,
                        Customers = AppData.Customers,
                        IsExitSaving = AppData.IsExitSaving
                    };

                    SaveData(container);
                    MessageBox.Show("Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            mainForm.FormClosing += _autoSaveHandler;
        }
        public static void DisableAutoSave(Form mainForm)
        {
            if (mainForm != null && _autoSaveHandler != null)
            {
                var container = new AppDataContainer
                {
                    Items = AppData.Items,
                    Customers = AppData.Customers,
                    IsExitSaving = AppData.IsExitSaving
                };

                SaveData(container);
                mainForm.FormClosing -= _autoSaveHandler;
                _autoSaveHandler = null;
            }
        }
    }

    /// <summary>
    /// Контейнер для данных приложения.
    /// </summary>
    public class AppDataContainer
    {
        public List<Item> Items { get; set; }
        public List<Customer> Customers { get; set; }
        public bool IsExitSaving { get; set; }
    }
}