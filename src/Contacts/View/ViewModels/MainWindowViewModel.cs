using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using View.Models;
using View.Models.Commands;
using View.Services;
using View.ViewModels.Base;

namespace View.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        private ObservableCollection<Contact> _contacts;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private Contact _selectedContact;

        /// <summary>
        /// Редактируемый контакт (для временного хранения).
        /// </summary>
        private Contact _editableContact;

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        private bool _isAdding;

        /// <summary>
        /// Флаг режима редактирования.
        /// </summary>
        private bool _isEditing;

        /// <summary>
        /// Текст для поиска.
        /// </summary>
        private string _searchText;

        /// <summary>
        /// Отфильтрованная коллекция контактов.
        /// </summary>
        private ObservableCollection<Contact> _filteredContacts;

        /// <summary>
        /// Серилизатор контактов.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public MainWindowViewModel()
        {
            _contactSerializer = new ContactSerializer();
            _contacts = new ObservableCollection<Contact>();
            _editableContact = new Contact(string.Empty, string.Empty, string.Empty, null);
            _filteredContacts = new ObservableCollection<Contact>();


            LoadContacts();
        }

        /// <summary>
        /// Коллекция контактов.
        /// </summary>
        public ObservableCollection<Contact> Contacts { get => _contacts; set => Set(ref _contacts, value); }

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (Set(ref _selectedContact, value) && value != null && !IsAdding && !IsEditing)
                {
                    EditableContact = value;
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(PhoneNumber));
                    OnPropertyChanged(nameof(Email));
                    OnPropertyChanged(nameof(PhotoBytes));
                    OnPropertyChanged(nameof(HasPhoto));
                }
            }
        }

        /// <summary>
        /// Редактируемый контакт.
        /// </summary>
        public Contact EditableContact { get => _editableContact; set => Set(ref _editableContact, value); }

        /// <summary>
        /// Имя для отображения.
        /// </summary>
        public string Name
        {
            get => _editableContact?.Name ?? string.Empty;
            set
            {
                if (_editableContact != null)
                {
                    _editableContact.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Телефон для отображения.
        /// </summary>
        public string PhoneNumber
        {
            get => _editableContact?.PhoneNumber ?? string.Empty;
            set
            {
                if (_editableContact != null)
                {
                    _editableContact.PhoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Email для отображения.
        /// </summary>
        public string Email
        {
            get => _editableContact?.Email ?? string.Empty;
            set
            {
                if (_editableContact != null)
                {
                    _editableContact.Email = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Фото в виде байт для отображения.
        /// </summary>
        public byte[] PhotoBytes
        {
            get => _editableContact?.PhotoBytes;
            set
            {
                if (_editableContact != null)
                {
                    _editableContact.PhotoBytes = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(HasPhoto));
                }
            }
        }

        /// <summary>
        /// Текст для поиска.
        /// </summary>
        public string SearchText
        {
            get => _searchText;
            set
            {
                if (Set(ref _searchText, value))
                {
                    FilterContacts();
                }
            }
        }
        /// <summary>
        /// Отфильтрованная коллекция контактов.
        /// </summary>
        public ObservableCollection<Contact> FilteredContacts
        {
            get => _filteredContacts;
            set => Set(ref _filteredContacts, value);
        }
        /// <summary>
        /// Есть ли фото.
        /// </summary>
        public bool HasPhoto => PhotoBytes != null && PhotoBytes.Length > 0;

        /// <summary>
        /// Флаг режима добавления.
        /// </summary>
        public bool IsAdding
        {
            get => _isAdding;
            set
            {
                if (Set(ref _isAdding, value))
                {
                    OnPropertyChanged(nameof(IsReadOnly));
                    OnPropertyChanged(nameof(IsApplyVisible));
                    OnPropertyChanged(nameof(CanEditRemove));

                    CommandManager.InvalidateRequerySuggested();
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
                if (Set(ref _isEditing, value))
                {
                    OnPropertyChanged(nameof(IsReadOnly));
                    OnPropertyChanged(nameof(IsApplyVisible));
                    OnPropertyChanged(nameof(CanEditRemove));

                    CommandManager.InvalidateRequerySuggested();
                }
            }
        }

        /// <summary>
        /// Режим только для чтения.
        /// </summary>
        public bool IsReadOnly => !IsAdding && !IsEditing;

        /// <summary>
        /// Видимость кнопки Apply.
        /// </summary>
        public bool IsApplyVisible => IsAdding || IsEditing;

        /// <summary>
        /// Возможность редактирования/удаления.
        /// </summary>
        public bool CanEditRemove => SelectedContact != null && !IsAdding && !IsEditing;

        /// <summary>
        /// Команда добавления контакта.
        /// </summary>
        public ICommand AddCommand
        {
            get => new DelegateCommand((obj) =>
            {
                try
                {
                    SelectedContact = null;
                    EditableContact = new Contact(string.Empty, string.Empty, string.Empty, null);
                    IsAdding = true;

                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(PhoneNumber));
                    OnPropertyChanged(nameof(Email));
                    OnPropertyChanged(nameof(PhotoBytes));
                    OnPropertyChanged(nameof(HasPhoto));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }, (obj) => !IsAdding && !IsEditing);
        }

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public ICommand EditCommand
        {
            get => new DelegateCommand((obj) =>
            {
                try
                {
                    if (SelectedContact != null)
                    {
                        EditableContact = SelectedContact;
                        IsEditing = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }, (obj) => SelectedContact != null && !IsAdding && !IsEditing);
        }

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        public ICommand RemoveCommand
        {
            get => new DelegateCommand((obj) =>
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
                            EditableContact = new Contact(string.Empty, string.Empty, string.Empty, null);
                        }

                        SaveContacts();
                        MessageBox.Show("Контакт успешно удален!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении контакта: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }, (obj) => SelectedContact != null && !IsAdding && !IsEditing);
        }

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        public ICommand ApplyCommand
        {
            get => new DelegateCommand((obj) =>
            {
                try
                {
                    if (IsAdding)
                    {
                        var newContact = new Contact(EditableContact.Name, EditableContact.PhoneNumber, EditableContact.Email, EditableContact.PhotoBytes);
                        _contacts.Add(newContact);
                        FilterContacts();

                        var addedInFiltered = FilteredContacts.FirstOrDefault(c => c == newContact);
                        if (addedInFiltered != null)
                        {
                            SelectedContact = addedInFiltered;
                        }

                        IsAdding = false;
                        MessageBox.Show("Контакт успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    if (IsEditing && SelectedContact != null)
                    {
                        SelectedContact.Name = EditableContact.Name;
                        SelectedContact.PhoneNumber = EditableContact.PhoneNumber;
                        SelectedContact.Email = EditableContact.Email;
                        SelectedContact.PhotoBytes = EditableContact.PhotoBytes;

                        FilterContacts();

                        IsEditing = false;
                        MessageBox.Show("Изменения успешно сохранены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    SaveContacts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }, (obj) => IsAdding || IsEditing);
        }

        /// <summary>
        /// Команда выбора фото.
        /// </summary>
        public ICommand SelectPhotoCommand
        {
            get => new DelegateCommand((obj) =>
            {
                try
                {
                    var dialog = new OpenFileDialog();
                    dialog.Filter = "Image files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
                    dialog.Title = "Выберите фото контакта";

                    if (dialog.ShowDialog() == true)
                    {
                        PhotoBytes = File.ReadAllBytes(dialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке фото: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }, (obj) => IsAdding || IsEditing);
        }

        /// <summary>
        /// Команда очистки фото.
        /// </summary>
        public ICommand ClearPhotoCommand
        {
            get => new DelegateCommand((obj) =>
            {
                try
                {
                    PhotoBytes = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }, (obj) => IsAdding || IsEditing);
        }

        /// <summary>
        /// Команда добавления случайного контакта.
        /// </summary>
        public ICommand AddRandomCommand
        {
            get => new DelegateCommand((obj) =>
            {
                try
                {
                    var random = new Random();
                    List<string> firstNames = new List<string>() { "Иван", "Петр", "Сергей", "Анна", "Мария", "Елена", "Дмитрий", "Алексей" };
                    List<string> lastNames = new List<string>() { "Иванов", "Петров", "Сидоров", "Смирнов", "Кузнецов", "Попов", "Лебедев", "Козлов" };
                    List<string> domains = new List<string>() { "gmail.com", "yandex.ru", "mail.ru", "outlook.com" };

                    string firstName = firstNames[random.Next(firstNames.Count)];
                    string lastName = lastNames[random.Next(lastNames.Count)];
                    string name = $"{firstName} {lastName}";

                    string phone = $"+7 ({random.Next(900, 999)}) {random.Next(100, 999)}-{random.Next(10, 99)}-{random.Next(10, 99)}";

                    string email = $"{firstName.ToLower()}.{lastName.ToLower()}@{domains[random.Next(domains.Count)]}";

                    var newContact = new Contact(name, phone, email, null);

                    Contacts.Add(newContact);
                    FilterContacts();

                    var addedInFiltered = FilteredContacts.FirstOrDefault(c => c == newContact);
                    if (addedInFiltered != null)
                    {
                        SelectedContact = addedInFiltered;
                    }

                    SaveContacts();

                    MessageBox.Show("Случайный контакт успешно добавлен!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении случайного контакта: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            });
        }

        /// <summary>
        /// Загрузка контактов из файла.
        /// </summary>
        private void LoadContacts()
        {
            try
            {
                var loadedContacts = _contactSerializer.Load();
                if (loadedContacts != null)
                {
                    _contacts = new ObservableCollection<Contact>(loadedContacts);
                    FilterContacts();

                    if (FilteredContacts.Count > 0)
                    {
                        SelectedContact = FilteredContacts[0];
                    }

                    MessageBox.Show("Контакты успешно загружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Файл с контактами не найден или произошла ошибка при загрузке!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Фильтрация контактов по поисковому запросу.
        /// </summary>
        private void FilterContacts()
        {
            if (string.IsNullOrWhiteSpace(_searchText))
            {
                FilteredContacts = new ObservableCollection<Contact>(_contacts);
            }
            else
            {
                var filtered = _contacts.Where(c => c.Name?.IndexOf(_searchText, StringComparison.OrdinalIgnoreCase) >= 0);
                FilteredContacts = new ObservableCollection<Contact>(filtered);
            }
            if (FilteredContacts.Count > 0 && !FilteredContacts.Contains(SelectedContact))
            {
                SelectedContact = FilteredContacts[0];
            }
            if (FilteredContacts.Count == 0)
            {
                SelectedContact = null;
            }
        }

        /// <summary>
        /// Сохранение контактов в файл.
        /// </summary>
        private void SaveContacts()
        {
            try
            {
                _contactSerializer.Save(Contacts.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}