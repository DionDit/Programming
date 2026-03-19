using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using View.Models;
using View.Models.Commands;
using View.Services;
using View.ViewModels.Base;

namespace View.ViewModels
{
    /// <summary>
    /// ViewModel главного окна.
    /// </summary>
    public class MainWindowViewModel : ViewModel
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        private ObservableCollection<ContactViewModel> _contacts;

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        private ContactViewModel _selectedContact;

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
        private ObservableCollection<ContactViewModel> _filteredContacts;

        /// <summary>
        /// Сериализатор контактов.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Конструктор ViewModel главного окна.
        /// </summary>
        public MainWindowViewModel()
        {
            _contactSerializer = new ContactSerializer();
            _contacts = new ObservableCollection<ContactViewModel>();
            _filteredContacts = new ObservableCollection<ContactViewModel>();
            _editableContact = new ContactViewModel(string.Empty, string.Empty, string.Empty, null);
            LoadContacts();
        }

        /// <summary>
        /// Список контактов.
        /// </summary>
        public ObservableCollection<ContactViewModel> Contacts
        {
            get => _contacts;
            set => Set(ref _contacts, value);
        }

        /// <summary>
        /// Выбранный контакт.
        /// </summary>
        public ContactViewModel SelectedContact
        {
            get => _selectedContact;
            set
            {
                if (Set(ref _selectedContact, value) && value != null && !IsAdding && !IsEditing)
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
            set
            {
                Set(ref _editableContact, value);
            }
        }

        /// <summary>
        /// Текст поиска.
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
        /// Отфильтрованный список контактов.
        /// </summary>
        public ObservableCollection<ContactViewModel> FilteredContacts
        {
            get => _filteredContacts;
            set => Set(ref _filteredContacts, value);
        }

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
                    OnPropertyChanged(nameof(IsApplyVisible));
                    OnPropertyChanged(nameof(IsEditingEnabled));
                    OnPropertyChanged(nameof(CanEditRemove));
                    if (value)
                    {
                        EditableContact?.ValidateAll();
                    }
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
                    OnPropertyChanged(nameof(IsApplyVisible));
                    OnPropertyChanged(nameof(IsEditingEnabled));
                    OnPropertyChanged(nameof(CanEditRemove));
                    if (value && EditableContact != null)
                    {
                        EditableContact.ValidateAll();
                    }
                    CommandManager.InvalidateRequerySuggested();
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
        public ICommand AddCommand => new DelegateCommand((obj) =>
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
        }, (obj) => !IsAdding && !IsEditing);

        /// <summary>
        /// Команда редактирования контакта.
        /// </summary>
        public ICommand EditCommand => new DelegateCommand((obj) =>
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
        }, (obj) => SelectedContact != null && !IsAdding && !IsEditing);

        /// <summary>
        /// Команда удаления контакта.
        /// </summary>
        public ICommand RemoveCommand => new DelegateCommand((obj) =>
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
        }, (obj) => SelectedContact != null && !IsAdding && !IsEditing);

        /// <summary>
        /// Команда применения изменений.
        /// </summary>
        public ICommand ApplyCommand => new DelegateCommand((obj) =>
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

                    int index = _contacts.IndexOf(SelectedContact);
                    if (index >= 0)
                    {
                        _contacts[index] = SelectedContact;
                    }
                    FilterContacts();
                    IsEditing = false;
                }

                SaveContacts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }, (obj) => (IsAdding || IsEditing) && EditableContact != null && !EditableContact.HasErrors);

        /// <summary>
        /// Команда выбора фото.
        /// </summary>
        public ICommand SelectPhotoCommand => new DelegateCommand((obj) =>
        {
            try
            {
                if (EditableContact == null)
                {
                    return;
                }
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
        }, (obj) => IsAdding || IsEditing);

        /// <summary>
        /// Команда очистки фото.
        /// </summary>
        public ICommand ClearPhotoCommand => new DelegateCommand((obj) =>
        {
            if (EditableContact != null)
            {
                EditableContact.PhotoBytes = null;
            }
        }, (obj) => IsAdding || IsEditing);

        /// <summary>
        /// Команда добавления случайного контакта.
        /// </summary>
        public ICommand AddRandomCommand => new DelegateCommand((obj) =>
        {
            try
            {
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
        public ICommand CancelCommand => new DelegateCommand((obj) =>
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
        }, (obj) => IsAdding || IsEditing);

        /// <summary>
        /// Загрузка контактов.
        /// </summary>
        private void LoadContacts()
        {
            try
            {
                var loadedContacts = _contactSerializer.Load();
                if (loadedContacts != null)
                {
                    _contacts = new ObservableCollection<ContactViewModel>(loadedContacts);
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
                _contactSerializer.Save(Contacts.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении контактов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}