using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using View.Models;

namespace View.Services
{
    /// <summary>
    /// Предоставляет методы для сериализации и десериализации контактов в JSON-файл.
    /// </summary>
    public class ContactSerializer
    {
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
        /// Сохраняет контакт в файл
        /// </summary>
        /// <param name="contact">Контакт для сохранения</param>
        public bool Save(List<Contact> contacts)
        {
            try
            {
                string json = JsonConvert.SerializeObject(contacts, Formatting.Indented);
                File.WriteAllText(FilePath, json);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Загружает контакт из файла
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
                return JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
            }
            catch
            {
                return new List<Contact>();
            }
        }
    }
}