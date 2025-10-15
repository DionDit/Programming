using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ObjectOrientedPractics.Model;

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
        /// Настройки сериализатора для обработки ссылок.
        /// </summary>
        private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            TypeNameHandling = TypeNameHandling.Auto,
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
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                }
                else
                {
                    AppData.Items = new List<Item>();
                    AppData.Customers = new List<Customer>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке: {ex.Message}", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
                AppData.Items = new List<Item>();
                AppData.Customers = new List<Customer>();
            }
        }

        /// <summary>
        /// Исправляет ссылки на товары в корзинах и заказах
        /// </summary>
        private static void FixItemReferences()
        {
            if (AppData.Items == null && AppData.Customers == null)
            {
                AppData.Items = new List<Item>();
                AppData.Customers = new List<Customer>();
            }

            var itemDict = AppData.Items
                .Where(item => item != null)
                .GroupBy(item => item.Id)
                .ToDictionary(g => g.Key, g => g.First());

            foreach (var customer in AppData.Customers)
            {
                if (customer == null)
                {
                    continue;
                }

                if (customer.Cart == null)
                {
                    customer.Cart = new Cart();
                }
                else if (customer.Cart.Items != null)
                {
                    customer.Cart.Items = customer.Cart.Items
                        .Where(item => item != null && itemDict.ContainsKey(item.Id))
                        .Select(item => itemDict[item.Id])
                        .ToList();
                }

                if (customer.Orders != null)
                {
                    foreach (var order in customer.Orders)
                    {
                        if (order != null && order.Items != null)
                        {
                            order.Items = order.Items
                                .Where(item => item != null && itemDict.ContainsKey(item.Id))
                                .Select(item => itemDict[item.Id])
                                .ToList();
                        }
                    }
                }
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
                    MessageBox.Show("Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SaveData(new { Items = AppData.Items, Customers = AppData.Customers, IsExitSaving = AppData.IsExitSaving });
                }
            };

            mainForm.FormClosing += _autoSaveHandler;
        }
        public static void DisableAutoSave(Form mainForm)
        {
            if (mainForm != null && _autoSaveHandler != null)
            {
                SaveData(new { Items = AppData.Items, Customers = AppData.Customers, IsExitSaving = AppData.IsExitSaving });
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