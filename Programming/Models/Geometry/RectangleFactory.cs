using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Models.Geometry
{
    /// <summary>
    /// Создает случайные экземпляры класса <see cref="Rectangle"/>.
    /// </summary>
    public static class RectangleFactory
    {
        /// <summary>
        /// Экземпляр класса <see cref="Random"/>.
        /// </summary>
        private static Random Random = new Random();

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <returns>Прямоугольник со случайными значениями.</returns>
        public static Rectangle Randomize()
        {
            int width = Random.Next(10, 350);
            int height = Random.Next(10, 350);

            int x = Random.Next(1, width / 2);
            int y = Random.Next(1, height / 2);

            return new Rectangle(new Point2D(x + width / 2, y + height / 2), width, height, "Black");
        }
    }
}
