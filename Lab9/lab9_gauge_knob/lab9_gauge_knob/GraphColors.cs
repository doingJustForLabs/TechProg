using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class GraphColors
    {

        private static readonly System.Drawing.Color[] predefinedColors =
        {
            System.Drawing.Color.Blue,
            System.Drawing.Color.Red,
            System.Drawing.Color.Green,
            System.Drawing.Color.Orange,
            System.Drawing.Color.Purple,
            System.Drawing.Color.Black
        };

        public static System.Drawing.Color GetSeriesColor(int index)
        {
            if (index < predefinedColors.Length)
                return predefinedColors[index];
            Random rand = new Random(index);
            return System.Drawing.Color.FromArgb(rand.Next(100, 256), rand.Next(100, 256), rand.Next(100, 256));
        }
    }
}
