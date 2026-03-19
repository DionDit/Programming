using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using View.Models;
using View.ViewModels.Base;

namespace View.ViewModels
{
    /// <summary>
    /// ViewModel для контакта.
    /// </summary>
    public class ContactViewModel: ViewModel, INotifyDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Email контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Фото контакта.
        /// </summary>
        private byte[] _photoBytes;

        /// <summary>
        /// Словарь ошибок валидации.
        /// </summary>
        private readonly Dictionary<string, List<string>> _errors = new();

        /// <summary>
        /// Событие изменения ошибок валидации.
        /// </summary>
        public event EventHandler<DataErrorsChangedEventArgs> ErrorsChanged;

        /// <summary>
        /// Имя контакта.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (Set(ref _name, value ?? string.Empty))
                {
                    ValidateName();
                }
            }
        }

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (Set(ref _phoneNumber, value ?? string.Empty))
                {
                    ValidatePhoneNumber();
                }
            }
        }

        /// <summary>
        /// Email контакта.
        /// </summary>
        public string Email
        {
            get => _email;
            set
            {
                if (Set(ref _email, value ?? string.Empty))
                {
                    ValidateEmail();
                }
            }
        }

        /// <summary>
        /// Фото контакта.
        /// </summary>
        public byte[] PhotoBytes
        {
            get => _photoBytes;
            set
            {
                if (Set(ref _photoBytes, value))
                {
                    OnPropertyChanged(nameof(HasPhoto));
                }
            }
        }

        /// <summary>
        /// Флаг наличия фото.
        /// </summary>
        public bool HasPhoto => PhotoBytes != null && PhotoBytes.Length > 0;

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public ContactViewModel()
        {
            _name = string.Empty;
            _phoneNumber = string.Empty;
            _email = string.Empty;
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        public ContactViewModel(string name, string phoneNumber, string email, byte[] photoBytes = null)
        {
            _name = name ?? string.Empty;
            _phoneNumber = phoneNumber ?? string.Empty;
            _email = email ?? string.Empty;
            _photoBytes = photoBytes;
        }

        /// <summary>
        /// Клонирование контакта.
        /// </summary>
        public ContactViewModel Clone()
        {
            return new ContactViewModel
            {
                Name = this.Name,
                PhoneNumber = this.PhoneNumber,
                Email = this.Email,
                PhotoBytes = this.PhotoBytes?.ToArray()
            };
        }

        /// <summary>
        /// Копирование данных из другого контакта.
        /// </summary>
        public void CopyFrom(ContactViewModel other)
        {
            if (other == null)
            {
                return;
            }
            else
            {
                Name = other.Name;
                PhoneNumber = other.PhoneNumber;
                Email = other.Email;
                PhotoBytes = other.PhotoBytes?.ToArray();
            }
        }

        /// <summary>
        /// Флаг наличия ошибок валидации.
        /// </summary>
        public bool HasErrors => _errors.Any();

        /// <summary>
        /// Получение ошибок валидации.
        /// </summary>
        public IEnumerable GetErrors(string propertyName)
        {
            if (propertyName != null && _errors.ContainsKey(propertyName))
            {
                return _errors[propertyName];
            }
            return Enumerable.Empty<string>();
        }

        /// <summary>
        /// Валидация всех свойств.
        /// </summary>
        public void ValidateAll()
        {
            ValidateName();
            ValidatePhoneNumber();
            ValidateEmail();
        }

        /// <summary>
        /// Валидация имени.
        /// </summary>
        private void ValidateName()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(_name))
            {
                errors.Add("Имя обязательно для заполнения");
            }
            if (_name.Length > 100)
            {
                errors.Add("Имя не должно превышать 100 символов");
            }
            UpdateErrors(nameof(Name), errors);
        }

        /// <summary>
        /// Валидация телефона.
        /// </summary>
        private void ValidatePhoneNumber()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(_phoneNumber))
            {
                errors.Add("Номер телефона обязателен для заполнения");
            }
            if (_phoneNumber.Length > 100)
            {
                errors.Add("Номер телефона не должен превышать 100 символов");
            }
            if (!string.IsNullOrEmpty(_phoneNumber))
            {
                if (!Regex.IsMatch(_phoneNumber, @"^[0-9+\-\(\)\s]+$"))
                {
                    errors.Add("Номер телефона может содержать только цифры и символы + - ( )");
                }
            }
            UpdateErrors(nameof(PhoneNumber), errors);
        }

        /// <summary>
        /// Валидация email.
        /// </summary>
        private void ValidateEmail()
        {
            var errors = new List<string>();
            if (string.IsNullOrWhiteSpace(_email))
            {
                errors.Add("Email обязателен для заполнения");
            }
            if (_email.Length > 100)
            {
                errors.Add("Email не должен превышать 100 символов");
            }
            if (!string.IsNullOrEmpty(_email) && !_email.Contains('@'))
            {
                errors.Add("Email должен содержать символ @");
            }
            UpdateErrors(nameof(Email), errors);
        }

        /// <summary>
        /// Обновление ошибок для свойства
        /// </summary>
        private void UpdateErrors(string propertyName, List<string> errors)
        {
            if (errors.Any())
            {
                _errors[propertyName] = errors;
            }
            else
            {
                _errors.Remove(propertyName);
            }
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
            OnPropertyChanged(nameof(HasErrors));
        }
    }
}