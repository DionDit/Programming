namespace Model.Models
{
    /// <summary>
    /// Длә сериализации контактов.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// Email контакта.
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// Фото контакта.
        /// </summary>
        public byte[]? PhotoBytes { get; set; }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        public Contact(string name, string phoneNumber, string email, byte[]? photoBytes = null)
        {
            Name = name ?? string.Empty;
            PhoneNumber = phoneNumber ?? string.Empty;
            Email = email ?? string.Empty;
            PhotoBytes = photoBytes;
        }
    }
}
