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
        public bool Save(Contact contact)
        {
            try
            {
                EnsureDirectoryExists();
                string json = JsonConvert.SerializeObject(contact, Formatting.Indented);
                File.WriteAllText(FilePath, json);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                return false;
            }
        }

        /// <summary>
        /// Загружает контакт из файла
        /// </summary>
        public Contact Load()
        {
            try
            {
                if (!File.Exists(FilePath))
                {
                    return new Contact(string.Empty, string.Empty, string.Empty);
                }

                string json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<Contact>(json) ?? new Contact(string.Empty, string.Empty, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return new Contact(string.Empty, string.Empty, string.Empty);
            }
        }
    }
}