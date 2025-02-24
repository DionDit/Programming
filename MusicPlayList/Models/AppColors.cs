using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models
{
    /// <summary>
    /// Набор цветов в приложении.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет элемента управления при возникновении ошибки валидации.
        /// </summary>
        public static Color ErrorInput { get => Color.LightPink; }

        /// <summary>
        /// Базовый цвет элемента управления.
        /// </summary>
        public static Color BaseInput { get => Color.White; }
    }
}
