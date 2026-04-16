using Model.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Formatting = Newtonsoft.Json.Formatting;

namespace Model.Services
{
    /// <summary>
    /// Cериализация и десериализация контактов в JSON-файл.
    /// </summary>
    public class ContactSerializer
    {
        // TODO: не должно быть строчек длиннее 100 символов. Исправить во всем решении
        /// <summary>
        /// Текущий путь к файлу.
        /// </summary>
        public string FilePath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        /// <summary>
        /// Конструктор класса <see cref="ContactSerializer"./>
        /// </summary>
        public ContactSerializer()
        {
            EnsureDirectoryExists();
        }

        /// <summary>
        /// Создает директорию, если она не существует.
        /// </summary>
        private void EnsureDirectoryExists()
        {
            string directory = Path.GetDirectoryName(FilePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        /// <summary>
        /// Сохраняет контакты в файл.
        /// </summary>
        public bool Save(List<Contact> contacts)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
                string json = JsonConvert.SerializeObject(contacts, settings);
                File.WriteAllText(FilePath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Загружает контакт из файла.
        /// </summary>
        public List<Contact> Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    return new List<Contact>();
                }
                string json = File.ReadAllText(FilePath);
                var contacts = JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
                return contacts;
            }
            catch
            {
                return new List<Contact>();
            }
        }
    }
}
