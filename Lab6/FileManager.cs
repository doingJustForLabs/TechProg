using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public static class FileManager
    {
        public static void DataToRezFiles(TabControl tabControl, List<double> x, List<double> y)
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                TabPage tabPage = tabControl.TabPages[i];
                string fileName = $"G{i + 1:0000}.rez";

                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine($"N\tX\tY\tG(x,y)");

                    for (int j = 0; j < x.Count; j++)
                    {
                        writer.WriteLine($"{j + 1}\t{x[j]}\t{y[j]}\t{CalculateManager.G(x[j], y[j])}");
                    }
                }
            }
        }
    }
}
