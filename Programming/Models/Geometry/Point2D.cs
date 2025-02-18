using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Geometry
{
    /// <summary>
    /// Точка в пространстве.
    /// </summary>
    public class Point2D
    {
        #region Fields
        /// <summary>
        /// Значение Х.
        /// </summary>
        private double _x;

        /// <summary>
        /// Значение Y.
        /// </summary>
        private double _y;
        #endregion

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="X">Значение Х</param>
        /// <param name="Y">Значение Y</param>
        public Point2D(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        #region Properties
        /// <summary>
        /// Значение X.
        /// </summary>
        public double X
        {
            get
            {
                return _x;
            }
            private set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(X)))
                {
                    _x = value;
                }
            }
        }

        /// <summary>
        /// Значение Y.
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }
            private set
            {
                if (Validator.AssertOnPositiveValue(value, nameof(Y)))
                {
                    _y = value;
                }
            }
        }
        #endregion
    }
}
