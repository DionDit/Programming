using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.Models.Geometry
{
    public static class RectangleFactory
    {
        private static Random Random = new Random();

        public static Rectangle Randomize(int Padding, Panel panel)
        {
            int width = Random.Next(10, 350);
            int height = Random.Next(10, 350);

            int x = Random.Next(Padding, panel.Width - width - Padding);
            int y = Random.Next(Padding, panel.Height - height - Padding);

            return new Rectangle(new Point2D(x + width / 2,y + height / 2), width, height, "Black");
        }
    }
}
