using ViewModel.ViewModels;

namespace ViewModel.Utils
{
    /// <summary>
    /// Генератор случайных тестовых данных для контактов.
    /// Используется только для отладки и тестирования.
    /// </summary>
    public static class FakeDataGenerator
    {
        /// <summary>
        /// Генератор случайных чисел.
        /// </summary>
        private static readonly Random _random = new();

        /// <summary>
        /// Список возможных имён.
        /// </summary>
        private static readonly List<string> _firstNames = new() { "Иван", "Петр", "Сергей", "Анна", "Мария", "Елена" };

        /// <summary>
        /// Список возможных фамилий.
        /// </summary>
        private static readonly List<string> _lastNames = new() { "Иванов", "Петров", "Сидоров", "Смирнова", "Кузнецова" };

        /// <summary>
        /// Список возможных доменов для email.
        /// </summary>
        private static readonly List<string> _domains = new() { "gmail.com", "yandex.ru", "mail.ru" };

        /// <summary>
        /// Генерирует случайный контакт с вымышленными данными.
        /// </summary>
        /// <returns>Новый экземпляр ContactVM</returns>
        public static ContactVM GenerateRandomContact()
        {
            string firstName = _firstNames[_random.Next(_firstNames.Count)];
            string lastName = _lastNames[_random.Next(_lastNames.Count)];
            string name = $"{firstName} {lastName}";

            string phone = $"+7({_random.Next(900, 999)}){_random.Next(100, 999)}-{_random.Next(10, 99)}-{_random.Next(10, 99)}";
            string email = $"{firstName.ToLower()}.{lastName.ToLower()}@{_domains[_random.Next(_domains.Count)]}";

            return new ContactVM(name, phone, email, null);
        }
    }
}