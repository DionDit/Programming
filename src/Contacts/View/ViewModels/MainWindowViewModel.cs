using System;
using System.Collections.Generic;
using System.Text;
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
        /// Модель контакта.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Серилизатор контакта.
        /// </summary>
        private readonly ContactSerializer _contactSerializer;

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public MainWindowViewModel()
        {
            _contact = new Contact(string.Empty, string.Empty, string.Empty);
            _contactSerializer = new ContactSerializer();
        } 

        /// <summary>
        /// Контакт, хранящий актуальную информацию из UI
        /// </summary>
        public Contact Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                OnPropertyChanged();

                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(PhoneNumber));
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get => _contact?.Name ?? string.Empty;
            set
            {
                if (_contact == null) 
                {
                    _contact = new Contact(value, string.Empty, string.Empty);
                }
                else
                {
                    _contact.Name = value;
                }
                OnPropertyChanged();
            }
        }
        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _contact?.PhoneNumber ?? string.Empty;
            set
            {
                if (_contact == null)
                {
                    _contact = new Contact(string.Empty, value, string.Empty);
                }
                else
                {
                    _contact.PhoneNumber = value;
                }
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        public string Email
        {
            get => _contact?.Email ?? string.Empty;
            set
            {
                if (_contact == null)
                {
                    _contact = new Contact(string.Empty, string.Empty, value);
                }
                else
                {
                    _contact.Email = value;
                }
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Команда сохранения текущего контакта в файл.
        /// </summary>
        public ICommand SaveCommand
        {
            get => new DelegateCommand((obj) =>
            {
                try
                {
                    bool result = _contactSerializer.Save(_contact);
                    if (result)
                    {
                        System.Windows.MessageBox.Show("Контакт успешно сохранен!", "Уведомление", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Ошибка при сохранении контакта!", "Ошибка", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                }
            });
        }

        /// <summary>
        /// Команда загрузки контакта из файла.
        /// </summary>
        public ICommand LoadCommand
        {
            get => new DelegateCommand((obj) =>
            {
                try
                {
                    Contact loadedContact = _contactSerializer.Load();
                    if (loadedContact != null)
                    {
                        Contact = loadedContact;
                        System.Windows.MessageBox.Show("Контакт успешно загружен!", "Уведомление", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
                    }
                    else
                    {
                        System.Windows.MessageBox.Show("Файл с контактом не найден или произошла ошибка при загрузке!", "Ошибка", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Warning);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                }
            });
        }
    }
}