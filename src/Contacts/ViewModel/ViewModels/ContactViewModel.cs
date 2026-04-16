using CommunityToolkit.Mvvm.ComponentModel;
using Model.Models;
using System.Collections;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ViewModel.ViewModels
{
    // TODO: для классов ViewModel в названии лучше использовать
    // аббревиатуру VM вместо полного написания. Исправить в обоих классах и именах переменных.
    /// <summary>
    /// ViewModel для контакта.
    /// </summary>
    public partial class ContactViewModel : ObservableObject, INotifyDataErrorInfo
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name = string.Empty;

        /// <summary>
        /// Номер телефона контакта.
        /// </summary>
        private string _phoneNumber = string.Empty;

        /// <summary>
        /// Email контакта.
        /// </summary>
        private string _email = string.Empty;

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
                if (SetProperty(ref _name, value ?? string.Empty))
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
                if (SetProperty(ref _phoneNumber, value ?? string.Empty))
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
                if (SetProperty(ref _email, value ?? string.Empty))
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
                if (SetProperty(ref _photoBytes, value))
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
        }

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Email.</param>
        /// <param name="photoBytes">Фото контакта.</param>
        public ContactViewModel(string name, string phoneNumber, string email, byte[] photoBytes = null)
        {
            _name = name ?? string.Empty;
            _phoneNumber = phoneNumber ?? string.Empty;
            _email = email ?? string.Empty;
            _photoBytes = photoBytes;
        }

        // Метод Clone() предполагает, что это метод интерфейса ICloneable.
        // Или сделать реализацию интерфейса ICloneable и метод должен возвращать object;
        // или сделать конструктор копирования, который как раз возвращает конкретный тип данных
        /// <summary>
        /// Клонирование контакта.
        /// </summary>
        /// <returns>Копия контакта.</returns>
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
        /// <param name="other">Контакт-источник.</param>
        public void CopyFrom(ContactViewModel other)
        {
            if (other == null)
            {
                return;
            }

            Name = other.Name;
            PhoneNumber = other.PhoneNumber;
            Email = other.Email;
            PhotoBytes = other.PhotoBytes?.ToArray();
        }

        /// <summary>
        /// Флаг наличия ошибок валидации.
        /// </summary>
        public bool HasErrors => _errors.Any();

        /// <summary>
        /// Получение ошибок валидации.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        /// <returns>Ошибки валидации.</returns>
        public IEnumerable GetErrors(string propertyName)
        {
            if (propertyName != null && _errors.TryGetValue(propertyName, out var errors))
            {
                return errors;
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
            else if (_name.Length > 100)
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
            else if (_phoneNumber.Length > 100)
            {
                errors.Add("Номер телефона не должен превышать 100 символов");
            }
            else if (!Regex.IsMatch(_phoneNumber, @"^[0-9+\-\(\)\s]+$"))
            {
                errors.Add("Номер телефона может содержать только цифры и символы + - ( )");
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
            else if (_email.Length > 100)
            {
                errors.Add("Email не должен превышать 100 символов");
            }
            else if (!_email.Contains('@'))
            {
                errors.Add("Email должен содержать символ @");
            }
            else
            {
                string[] parts = _email.Split('@');
                if (parts.Length != 2)
                {
                    errors.Add("Неверный формат email");
                }
                else if (string.IsNullOrWhiteSpace(parts[0]))
                {
                    errors.Add("Отсутствует имя пользователя перед @");
                }
                else if (string.IsNullOrWhiteSpace(parts[1]))
                {
                    errors.Add("Отсутствует домен после @");
                }
                else if (!parts[1].Contains('.'))
                {
                    errors.Add("Домен должен содержать точку (например, gmail.com)");
                }
                else if (parts[1].EndsWith('.'))
                {
                    errors.Add("Домен не может заканчиваться на точку");
                }
            }

            UpdateErrors(nameof(Email), errors);
        }

        /// <summary>
        /// Обновление ошибок для свойства.
        /// </summary>
        /// <param name="propertyName">Имя свойства.</param>
        /// <param name="errors">Список ошибок.</param>
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

        /// <summary>
        /// Преобразование из Model в ViewModel.
        /// </summary>
        /// <param name="contact">Модель контакта.</param>
        /// <returns>ViewModel контакта.</returns>
        public static ContactViewModel FromModel(Contact contact)
        {
            if (contact == null)
            {
                return new ContactViewModel();
            }
            else
            {
                return new ContactViewModel(contact.Name, contact.PhoneNumber, contact.Email, contact.PhotoBytes);
            }
        }

        /// <summary>
        /// Преобразование из ViewModel в Model.
        /// </summary>
        /// <returns>Модель контакта.</returns>
        public Contact ToModel() => new Contact(this.Name, this.PhoneNumber, this.Email, this.PhotoBytes?.ToArray());
    }
}