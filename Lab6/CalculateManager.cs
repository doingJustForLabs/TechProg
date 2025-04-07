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
                return x / (y - 2);

            }
            catch (DivideByZeroException)
            {
                return double.NaN;
            }
            catch (OverflowException)
            {
                return double.NaN;
            }
        }
    }
}
