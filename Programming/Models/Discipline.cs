using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    /// <summary>
    /// Дисциплина.
    /// </summary>
    public class Discipline
    {
        #region Fields
        /// <summary>
        /// Название дисциплины.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия преподавателя.
        /// </summary>
        private string _teacherLastName;

        /// <summary>
        /// Оценка.
        /// </summary>
        private int _assessment;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        /// <param name="Name">Название.</param>
        /// <param name="TeacherLastName">ФИО преподавателя.</param>
        /// <param name="Assessment">Оценка</param>
        public Discipline(string Name, string TeacherLastName, int Assessment)
        {
            this.Name = Name;
            this.TeacherLastName = TeacherLastName;
            this.Assessment = Assessment;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Discipline"/>.
        /// </summary>
        public Discipline()
        {

        }

        #region Properties
        /// <summary>
        /// Название дисциплины.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение названия");
                }
            }
        }

        /// <summary>
        /// Фамилия преподавателя.
        /// </summary>
        public string TeacherLastName
        {
            get
            {
                return _teacherLastName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _teacherLastName = value;
                }
                else
                {
                    throw new ArgumentException("Невозможное значение фамилии преподавателя");
                }
            }
        }

        /// <summary>
        /// Оценка.
        /// </summary>
        public int Assessment
        {
            get
            {
                return _assessment;
            }
            set
            {
                if (Validator.AssertValueInRange(value,1,5,nameof(Assessment)))
                {
                    _assessment = value;
                }
            }
        }
        #endregion
    }
}
