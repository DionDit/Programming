using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using Model.Services;
using System.Collections.ObjectModel;
using System.Windows;

namespace ViewModel.ViewModels
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    public partial class MainWindowViewModel : ObservableObject
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        private ObservableCollection<ContactViewModel> _contacts = new();

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private ContactViewModel _selectedContact;

        // TODO: дописать в комментарии, чем редактируемый контакт отличается от выбранного.
        // Потому что по идее это должно быть одно и то же. А если есть отличие, но надо
        // объяснить сокомандникам в чем нюанс.
        /// <summary>
        /// Редактируемый контакт.
        /// </summary>
        private ContactViewModel _editableContact;

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        private bool _isAdding;

        /// <summary>
        /// Флаг режима редактирования.
        /// </summary>
        private bool _isEditing;

        /// <summary>
        /// Текст поиска.
        /// </summary>
        private string _searchText = string.Empty;

        /// <summary>
        /// Отфильтрованный список контактов.
        /// </summary>
        private ObservableCollection<ContactViewModel> _filteredContacts = new();

        /// <summary>
        /// Сериализатор контактов.
        /// </summary>
        private readonly ContactSerializer _contactSerializer = new();

        /// <summary>
        /// Конструктор ViewModel главного окна.
        /// </summary>
        public MainWindowViewModel()
        {
            LoadContacts();
        }

        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<ContactViewModel> Contacts
        {
            get => _contacts;
            set => SetProperty(ref _contacts, value);
        }

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        public ContactViewModel SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (SetProperty(ref _selectedContact, value) && value != null && !IsAdding && !IsEditing)
                {
                    EditableContact = value.Clone();
                }
            }
        }

        /// <summary>
        /// Редактируемый контакт.
        /// </summary>
        public ContactViewModel EditableContact
        {
            get => _editableContact;
            set => SetProperty(ref _editableContact, value);
        }

        /// <summary>
        /// Текст поиска.
        /// </summary>
        public string SearchText
        {
            get => _searchText;
            set
            {
                if (SetProperty(ref _searchText, value))
                {
                    FilterContacts();
                }
            }
        }

        /// <summary>
        /// Отфильтрованный список контактов.
        /// </summary>
        public ObservableCollection<ContactViewModel> FilteredContacts
        {
            get => _filteredContacts;
            set => SetProperty(ref _filteredContacts, value);
        }

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        public bool IsAdding
        {
            get => _isAdding;
            set
            {
                if (SetProperty(ref _isAdding, value))
                {
                    OnPropertyChanged(nameof(IsApplyVisible));
                    OnPropertyChanged(nameof(IsEditingEnabled));
                    OnPropertyChanged(nameof(CanEditRemove));
                    if (value)
                    {
                        EditableContact?.ValidateAll();
                    }
                    AddCommand.NotifyCanExecuteChanged();
                    EditCommand.NotifyCanExecuteChanged();
                    RemoveCommand.NotifyCanExecuteChanged();
                    ApplyCommand.NotifyCanExecuteChanged();
                    CancelCommand.NotifyCanExecuteChanged();
                    SelectPhotoCommand.NotifyCanExecuteChanged();
                    ClearPhotoCommand.NotifyCanExecuteChanged();
                }
            }
        }

        /// <summary>
        /// Флаг режима редактирования.
        /// </summary>
        public bool IsEditing
        {
            get => _isEditing;
            set
            {
                if (SetProperty(ref _isEditing, value))
                {
                    OnPropertyChanged(nameof(IsApplyVisible));
                    OnPropertyChanged(nameof(IsEditingEnabled));
                    OnPropertyChanged(nameof(CanEditRemove));
                    if (value && EditableContact != null)
                    {
                        EditableContact.ValidateAll();
                    }
                    
                    // TODO: ты вручную начинаешь обновлять состояния кнопочек,
                    // хотя для этого в MVVM Toolkit уже есть готовый механизм.
                    // Попробуй атрибут [RelayCommand] или другие механизмы,
                    // но такого перечня обновления состояний быть не должно
                    AddCommand.NotifyCanExecuteChanged();
                    EditCommand.NotifyCanExecuteChanged();
                    RemoveCommand.NotifyCanExecuteChanged();
                    ApplyCommand.NotifyCanExecuteChanged();
                    CancelCommand.NotifyCanExecuteChanged();
                    SelectPhotoCommand.NotifyCanExecuteChanged();
                    ClearPhotoCommand.NotifyCanExecuteChanged();
                }
            }
        }

        /// <summary>
        /// Видимость кнопок.
        /// </summary>
        public bool IsApplyVisible => IsAdding || IsEditing;

        /// <summary>
        /// Возможность редактирования/удаления.
        /// </summary>
        public bool CanEditRemove => SelectedContact != null && !IsAdding && !IsEditing;

        /// <summary>
        /// Доступность редактирования.
        /// </summary>
        public bool IsEditingEnabled => IsAdding || IsEditing;

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        public RelayCommand AddCommand => new RelayCommand(
            execute: () =>
            {
                try
                {
                    SelectedContact = null;
                    EditableContact = new ContactViewModel(string.Empty, string.Empty, string.Empty, null);
                    IsAdding = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            },
            canExecute: () => !IsAdding && !IsEditing
        );

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public RelayCommand EditCommand => new RelayCommand(
            execute: () =>
            {
                try
                {
                    if (SelectedContact != null)
                    {
                        EditableContact = SelectedContact.Clone();
                        IsEditing = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            },
            canExecute: () => SelectedContact != null && !IsAdding && !IsEditing
        );

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        public RelayCommand RemoveCommand => new RelayCommand(
            execute: () =>
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
                            if (index < FilteredContacts.Count)
                            {
                                SelectedContact = FilteredContacts[index];
                            }
                            else
                            {
                                SelectedContact = FilteredContacts[FilteredContacts.Count - 1];
                            }
                        }
                        else
                        {
                            SelectedContact = null;
                            EditableContact = new ContactViewModel(string.Empty, string.Empty, string.Empty, null);
                        }

                        SaveContacts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении контакта: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            },
            canExecute: () => SelectedContact != null && !IsAdding && !IsEditing
        );

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        public RelayCommand ApplyCommand => new RelayCommand(
            execute: () =>
            {
                try
                {
                    if (EditableContact?.HasErrors == true)
                    {
                        MessageBox.Show("Исправьте ошибки перед сохранением!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }

                    if (IsAdding)
                    {
                        var newContact = EditableContact.Clone();
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
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            },
            canExecute: () => !EditableContact.HasErrors
        );

        /// <summary>
        /// Команда выбора фото.
        /// </summary>
        public RelayCommand SelectPhotoCommand => new RelayCommand(
            execute: () =>
            {
                try
                {
                    if (EditableContact == null) return;

                    // TODO: обращаешься к экземплярам View - нарушение MVVM.
                    // Переделать на DI
                    // TODO: логику сервисных окон лучше выносить в отдельный класс
                    var dialog = new OpenFileDialog
                    {
                        Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*",
                        Title = "Выберите фото контакта"
                    };
                    if (dialog.ShowDialog() == true)
                    {
                        byte[] bytes = File.ReadAllBytes(dialog.FileName);
                        EditableContact.PhotoBytes = bytes;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            },
            canExecute: () => IsAdding || IsEditing
        );

        /// <summary>
        /// Команда очистки фото.
        /// </summary>
        public RelayCommand ClearPhotoCommand => new RelayCommand(
            execute: () =>
            {
                if (EditableContact != null)
                {
                    EditableContact.PhotoBytes = null;
                }
            },
            canExecute: () => true /*IsAdding || IsEditing*/
        );

        /// <summary>
        /// Команда добавления случайного контакта.
        /// </summary>
        public RelayCommand AddRandomCommand => new RelayCommand(() =>
        {
            try
            {
                // TODO: вынести в отдельный класс. В продакте не должно быть кода по генерации фейков
                var random = new Random();
                List<string> firstNames = new() { "Иван", "Петр", "Сергей", "Анна", "Мария", "Елена" };
                List<string> lastNames = new() { "Иванов", "Петров", "Сидоров", "Смирнова", "Кузнецова" };
                List<string> domains = new() { "gmail.com", "yandex.ru", "mail.ru" };

                string firstName = firstNames[random.Next(firstNames.Count)];
                string lastName = lastNames[random.Next(lastNames.Count)];
                string name = $"{firstName} {lastName}";

                string phone = $"+7({random.Next(900, 999)}){random.Next(100, 999)}-{random.Next(10, 99)}-{random.Next(10, 99)}";
                string email = $"{firstName.ToLower()}.{lastName.ToLower()}@{domains[random.Next(domains.Count)]}";

                var newContact = new ContactViewModel(name, phone, email, null);
                Contacts.Add(newContact);
                FilterContacts();
                SelectedContact = newContact;
                SaveContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        });

        /// <summary>
        /// Команда отмены.
        /// </summary>
        public RelayCommand CancelCommand => new RelayCommand(
            execute: () =>
            {
                try
                {
                    if (IsAdding)
                    {
                        IsAdding = false;
                        EditableContact = new ContactViewModel(string.Empty, string.Empty, string.Empty, null);
                    }
                    else if (IsEditing)
                    {
                        IsEditing = false;
                        if (SelectedContact != null)
                        {
                            EditableContact = SelectedContact.Clone();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            },
            canExecute: () => true /*IsAdding || IsEditing*/
        );

        /// <summary>
        /// Загрузка контактов.
        /// </summary>
        private void LoadContacts()
        {
            try
            {
                var loadedModels = _contactSerializer.Load(); // загружаем List<Contact>
                if (loadedModels != null)
                {
                    // Преобразуем List<Contact> в List<ContactViewModel>
                    var contacts = loadedModels.Select(model => ContactViewModel.FromModel(model)).ToList();
                    _contacts = new ObservableCollection<ContactViewModel>(contacts);
                    FilterContacts();
                    if (FilteredContacts.Count > 0)
                    {
                        SelectedContact = FilteredContacts[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Фильтрация контактов.
        /// </summary>
        private void FilterContacts()
        {
            if (string.IsNullOrWhiteSpace(_searchText))
            {
                FilteredContacts = new ObservableCollection<ContactViewModel>(_contacts);
            }
            else
            {
                // TODO: вынеси string?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) в inline-метод,
                // или сам принцип обхода и поиска по всем полям в отдельный метод
                var filtered = _contacts.Where(c =>
                            (c.Name?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                            (c.PhoneNumber?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                            (c.Email?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) >= 0));
                FilteredContacts = new ObservableCollection<ContactViewModel>(filtered);
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
        /// Сохранение контактов.
        /// </summary>
        private void SaveContacts()
        {
            try
            {
                // Преобразуем List<ContactViewModel> в List<Contact>
                var models = Contacts.Select(vm => vm.ToModel()).ToList();
                _contactSerializer.Save(models);
            }
            catch (Exception ex)
            {
                // TODO: в VM не должно быть вызовов MessageBox - это нарушение паттерна MVVM. Исправить
                MessageBox.Show($"Ошибка при сохранении контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}