using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model.Services;
using System.Collections.ObjectModel;
using ViewModel.Interfaces;
using ViewModel.Utils;

namespace ViewModel.ViewModels
{
    /// <summary>
    /// VM главного окна.
    /// </summary>
    public partial class MainWindowVM : ObservableObject
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        private ObservableCollection<ContactVM> _contacts = new();

        /// <summary>
        /// Отфильтрованный список контактов.
        /// </summary>
        private ObservableCollection<ContactVM> _filteredContacts = new();

        /// <summary>
        /// Сериализатор контактов.
        /// </summary>
        private readonly ContactSerializer _contactSerializer = new();

        /// <summary>
        /// Сервис для показа диалоговых окон.
        /// Реализует паттерн Dependency Injection для слабой связанности с View.
        /// </summary>
        private readonly IDialogService _dialogService;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        [ObservableProperty]
        private ContactVM? _selectedContact;

        /// <summary>
        /// Редактируемый контакт это копия SelectedContact.
        /// Используется для временного хранения изменений до подтверждения Apply
        /// или отмены Cancel. Это позволяет не изменять оригинал до сохранения.
        /// </summary>
        [ObservableProperty]
        private ContactVM? _editableContact;

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        [ObservableProperty]
        private bool _isAdding;

        /// <summary>
        /// Флаг режима редактирования.
        /// </summary>
        [ObservableProperty]
        private bool _isEditing;

        /// <summary>
        /// Текст поиска.
        /// </summary>
        [ObservableProperty]
        private string _searchText = string.Empty;

        /// <summary>
        /// Конструктор VM главного окна.
        /// </summary>
        /// <param name="dialogService">Сервис диалоговых окон.</param>
        public MainWindowVM(IDialogService dialogService)
        {
            _dialogService = dialogService;
            LoadContacts();
        }

        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts
        {
            get => _contacts;
            set => SetProperty(ref _contacts, value);
        }

        /// <summary>
        /// Отфильтрованный список контактов.
        /// </summary>
        public ObservableCollection<ContactVM> FilteredContacts
        {
            get => _filteredContacts;
            set => SetProperty(ref _filteredContacts, value);
        }

        /// <summary>
        /// Видимость кнопок применения.
        /// </summary>
        public bool IsApplyVisible => IsAdding || IsEditing;

        /// <summary>
        /// Возможность редактирования контакта.
        /// </summary>
        public bool CanEditRemove => SelectedContact != null && !IsAdding && !IsEditing;

        /// <summary>
        /// Доступность режима редактирования.
        /// </summary>
        public bool IsEditingEnabled => IsAdding || IsEditing;

        /// <summary>
        /// Вызывается при изменении выбранного контакта.
        /// </summary>
        partial void OnSelectedContactChanged(ContactVM? value)
        {
            if (value != null && !IsAdding && !IsEditing)
            {
                EditableContact = new ContactVM(value);
            }
        }

        /// <summary>
        /// Вызывается при изменении текста поиска.
        /// </summary>
        partial void OnSearchTextChanged(string value)
        {
            FilterContacts();
        }

        /// <summary>
        /// Вызывается при изменении флага режима добавления.
        /// </summary>
        partial void OnIsAddingChanged(bool value)
        {
            if (value)
            {
                EditableContact?.ValidateAll();
            }
            OnPropertyChanged(nameof(IsApplyVisible));
            OnPropertyChanged(nameof(CanEditRemove));
            OnPropertyChanged(nameof(IsEditingEnabled));
        }

        /// <summary>
        /// Вызывается при изменении флага режима редактирования.
        /// </summary>
        partial void OnIsEditingChanged(bool value)
        {
            if (value && EditableContact != null)
            {
                EditableContact.ValidateAll();
            }
            OnPropertyChanged(nameof(IsApplyVisible));
            OnPropertyChanged(nameof(CanEditRemove));
            OnPropertyChanged(nameof(IsEditingEnabled));
        }

        /// <summary>
        /// Проверяет, доступны ли команды добавления.
        /// </summary>
        private bool CanAddEdit() => !IsAdding && !IsEditing;

        /// <summary>
        /// Проверяет, доступна ли команда применения изменений.
        /// </summary>
        private bool CanApply() => EditableContact != null && !EditableContact.HasErrors;

        /// <summary>
        /// Проверяет, доступна ли команда выбора фото.
        /// </summary>
        private bool CanSelectPhoto() => IsAdding || IsEditing;

        /// <summary>
        /// Команда добавления нового контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanAddEdit))]
        private void Add()
        {
            try
            {
                SelectedContact = null;
                EditableContact = new ContactVM(string.Empty, string.Empty, string.Empty, null);
                IsAdding = true;
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Команда редактирования выбранного контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanAddEdit))]
        private void Edit()
        {
            try
            {
                if (SelectedContact != null)
                {
                    EditableContact = new ContactVM(SelectedContact);
                    IsEditing = true;
                }
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Команда удаления выбранного контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanAddEdit))]
        private void Remove()
        {
            try
            {
                if (SelectedContact != null)
                {
                    var contactToRemove = SelectedContact;
                    int index = _contacts.IndexOf(contactToRemove);
                    _contacts.Remove(contactToRemove);
                    FilterContacts();

                    if (FilteredContacts.Count > 0)
                    {
                        SelectedContact = index < FilteredContacts.Count
                            ? FilteredContacts[index]
                            : FilteredContacts[^1];
                    }
                    else
                    {
                        SelectedContact = null;
                        EditableContact = new ContactVM(string.Empty, string.Empty, string.Empty, null);
                    }

                    SaveContacts();
                }
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка при удалении контакта: {ex.Message}");
            }
        }

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanApply))]
        private void Apply()
        {
            try
            {
                if (EditableContact?.HasErrors == true)
                {
                    _dialogService.ShowWarning("Исправьте ошибки перед сохранением!");
                    return;
                }

                if (IsAdding)
                {
                    var newContact = new ContactVM(EditableContact);
                    _contacts.Add(newContact);
                    FilterContacts();
                    SelectedContact = newContact;
                    IsAdding = false;
                }
                else if (IsEditing && SelectedContact != null && EditableContact != null)
                {
                    SelectedContact.CopyFrom(EditableContact);
                    FilterContacts();
                    IsEditing = false;
                }

                SaveContacts();
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Команда выбора фото для контакта.
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanSelectPhoto))]
        private void SelectPhoto()
        {
            try
            {
                if (EditableContact == null)
                {
                    return;
                }

                var fileName = _dialogService.OpenFileDialog(
                    "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*",
                    "Выберите фото контакта");

                if (fileName != null)
                {
                    byte[] bytes = File.ReadAllBytes(fileName);
                    EditableContact.PhotoBytes = bytes;
                }
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Команда очистки фото контакта.
        /// </summary>
        [RelayCommand]
        private void ClearPhoto()
        {
            if (EditableContact != null)
            {
                EditableContact.PhotoBytes = null;
            }
        }

        /// <summary>
        /// Команда добавления случайного контакта для тестирования.
        /// </summary>
        [RelayCommand]
        private void AddRandom()
        {
            try
            {
                var newContact = FakeDataGenerator.GenerateRandomContact();
                Contacts.Add(newContact);
                FilterContacts();
                SelectedContact = newContact;
                SaveContacts();
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Команда отмены.
        /// </summary>
        [RelayCommand]
        private void Cancel()
        {
            try
            {
                if (IsAdding)
                {
                    IsAdding = false;
                    EditableContact = new ContactVM(string.Empty, string.Empty, string.Empty, null);
                }
                else if (IsEditing)
                {
                    IsEditing = false;
                    if (SelectedContact != null)
                    {
                        EditableContact = new ContactVM(SelectedContact);
                    }
                }
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка: {ex.Message}");
            }
        }

        /// <summary>
        /// Загрузка контактов из файла.
        /// </summary>
        private void LoadContacts()
        {
            try
            {
                var loadedModels = _contactSerializer.Load();
                if (loadedModels != null)
                {
                    var contacts = loadedModels.Select(model => ContactVM.FromModel(model)).ToList();
                    _contacts = new ObservableCollection<ContactVM>(contacts);
                    FilterContacts();
                    if (FilteredContacts.Count > 0)
                    {
                        SelectedContact = FilteredContacts[0];
                    }
                }
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка при загрузке контактов: {ex.Message}");
            }
        }

        /// <summary>
        /// Фильтрация контактов по поисковому запросу.
        /// </summary>
        private void FilterContacts()
        {
            if (string.IsNullOrWhiteSpace(_searchText))
            {
                FilteredContacts = new ObservableCollection<ContactVM>(_contacts);
            }
            else
            {
                var filtered = _contacts.Where(x => ContactMatchesSearch(x));
                FilteredContacts = new ObservableCollection<ContactVM>(filtered);
            }

            if (FilteredContacts.Count > 0 && !FilteredContacts.Contains(SelectedContact))
            {
                SelectedContact = FilteredContacts[0];
            }
            else if (FilteredContacts.Count == 0)
            {
                SelectedContact = null;
            }
        }

        /// <summary>
        /// Проверяет, соответствует ли контакт поисковому запросу.
        /// </summary>
        /// <param name="contact">Проверяемый контакт.</param>
        /// <returns>True, если контакт соответствует запросу.</returns>
        private bool ContactMatchesSearch(ContactVM contact)
        {
            if (string.IsNullOrWhiteSpace(_searchText))
            {
                return false;
            }

            return (contact.Name?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                   (contact.PhoneNumber?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                   (contact.Email?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        /// <summary>
        /// Сохранение контактов в файл.
        /// </summary>
        private void SaveContacts()
        {
            try
            {
                var models = Contacts.Select(vm => vm.ToModel()).ToList();
                _contactSerializer.Save(models);
            }
            catch (Exception ex)
            {
                _dialogService.ShowError($"Ошибка при сохранении контактов: {ex.Message}");
            }
        }
    }
}