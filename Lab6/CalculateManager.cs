using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    static class CalculateManager
    {
        public static double G(double x, double y)
        {
            try
            {
                if (y - 2 == 0)
                {
                    return double.NaN;
                }
                return x / (y - 2);
            }
            catch (OverflowException)
            {
                return double.NaN;
            }
            catch (Exception)
            {
                return double.NaN;
            }
        }
    }
}
