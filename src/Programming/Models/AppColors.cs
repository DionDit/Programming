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

        /// <summary>
        /// Цвет лета.
        /// </summary>
        public static Color Summer { get => Color.Green; }

        /// <summary>
        /// Цвет осени.
        /// </summary>
        public static Color Autumn { get => Color.Yellow; }

        /// <summary>
        /// Цвет зимы.
        /// </summary>
        public static Color Winter { get => Color.Blue; }

        /// <summary>
        /// Цвет весны.
        /// </summary>
        public static Color Spring { get => Color.Cyan; }

        /// <summary>
        /// Базовый цвет прямоугольника.
        /// </summary>
        public static Color RectangleBase { get => Color.FromArgb(127, 127, 255, 127); }

        /// <summary>
        /// Цвет прямоугольника при пересечении.
        /// </summary>
        public static Color RectangleCollision { get => Color.FromArgb(255, 255, 0, 0); }
    }
}
