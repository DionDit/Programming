using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Geometry
{
    /// <summary>
    /// Кольцо.
    /// </summary>
    public class Ring
    {
        #region Fields
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _innerRadius;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="OuterRadius">Внешний радиус.</param>
        /// <param name="InnerRadius">Внутренний радиус.</param>
        /// <param name="Center">Центр кольца.</param>
        public Ring(double OuterRadius, double InnerRadius, Point2D Center)
        {
            this.OuterRadius = OuterRadius;
            this.InnerRadius = InnerRadius;
            this.Center = Center;
        }

        #region Properties
        /// <summary>
        /// Внешний радиус.
        /// </summary>
        public double OuterRadius
        {
            get
            {
                return _outerRadius;
            }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(OuterRadius)) && Validator.AssertValueMore(value, InnerRadius, nameof(OuterRadius)))
                {
                    _outerRadius = value;
                }
            }
        }

        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        public double InnerRadius
        {
            get
            {
                return _innerRadius;
            }
            set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(InnerRadius)) && Validator.AssertValueLess(value, OuterRadius, nameof(InnerRadius)))
                {
                    _innerRadius = value;
                }
            }
        }

        /// <summary>
        /// Площадь кольца.
        /// </summary>
        public double Area { get => Math.PI * Math.Pow(OuterRadius, 2) - Math.PI * Math.Pow(InnerRadius, 2); }

        /// <summary>
        /// Центр кольца.
        /// </summary>
        public Point2D Center { get; set; }
        #endregion
    }
}
