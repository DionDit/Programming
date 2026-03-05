using System;
using System.Collections.Generic;
using System.Text;

namespace View.Models
{
    /// <summary>
    /// Класс, представляющий контакт человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Фото контакта в виде массива байт.
        /// </summary>
        public byte[] PhotoBytes { get; set; }

        /// <summary>
        /// Конструктор с параметрами для инициализации всех свойств.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string name, string phoneNumber, string email, byte[] photoBytes)
        {
            Name = name ?? string.Empty;
            PhoneNumber = phoneNumber ?? string.Empty;
            Email = email ?? string.Empty;
            PhotoBytes = photoBytes;
        }

        /// <summary>
        /// Переопределение метода ToString для удобного отображения.
        /// </summary>
        public override string ToString()=> $"Имя: {Name}, Телефон: {PhoneNumber}, Email: {Email}";
    }
}