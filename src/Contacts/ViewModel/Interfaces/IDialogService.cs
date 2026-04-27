namespace ViewModel.Interfaces
{
    /// <summary>
    /// Сервис для показа диалоговых окон.
    /// </summary>
    public interface IDialogService
    {
        /// <summary>
        /// Показывает информационное сообщение.
        /// </summary>
        void ShowMessage(string message, string title = "Информация");

        /// <summary>
        /// Показывает сообщение об ошибке.
        /// </summary>
        void ShowError(string message, string title = "Ошибка");

        /// <summary>
        /// Показывает предупреждение.
        /// </summary>
        void ShowWarning(string message, string title = "Предупреждение");

        /// <summary>
        /// Показывает диалог выбора файла.
        /// </summary>
        /// <param name="filter">Фильтр типов файлов.</param>
        /// <param name="title">Заголовок диалога.</param>
        /// <returns>Путь к выбранному файлу или null.</returns>
        string? OpenFileDialog(string filter, string title);
    }
}