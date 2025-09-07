using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Models.Geometry
{
    /// <summary>
    /// Проверяет объекты на пересечения.
    /// </summary>
    public static class CollisionManager
    {
        /// <summary>
        /// Проверяет, пересекаются ли прямоугольники.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true, если прямоугольники пересекаются.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            //Разница координат по модулю
            double deltaX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double deltaY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);

            //Сумма половин ширин и высот
            double sumHalfWidths = (rectangle1.Width + rectangle2.Width) / 2;
            double sumHalfHeights = (rectangle1.Height + rectangle2.Height) / 2;

            return deltaX < sumHalfWidths && deltaY < sumHalfHeights;

        }

        /// <summary>
        /// Проверяет, пересекаются ли кольца.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true, если кольца пересекаются.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            //Расстояние между центрами колец
            double deltaX = ring1.Center.X - ring2.Center.X;
            double deltaY = ring1.Center.Y - ring2.Center.Y;
            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            //Сумма внешних радиусов
            double sumOuterRadius = ring1.OuterRadius + ring2.OuterRadius;

            //Разница внешних радиусов вложенности
            double diffOuterRadius = Math.Abs(ring1.OuterRadius - ring2.OuterRadius);

            if (distance < sumOuterRadius)
            {
                if (distance > diffOuterRadius)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
