using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    static class IntegralMethods
    {
        public static double RightRectangleMethod(
            Func<double, double> func, 
            double a, 
            double b,
            double deltaX,
            DataTable data = null)
        {
            double sum = 0;

            int n = (int)Math.Ceiling((b - a) / deltaX);

            for (int i = 0; i < n; i++)
            {
                double x = a + i * deltaX; 
                double y = func(x + deltaX);
                sum += y * deltaX;

                data?.Rows.Add(i + 1, x, y, sum);
            }

            return sum;
        }

        public static double LeftRectangleMethod(
            Func<double, double> func,
            double a,
            double b,
            double deltaX,
            DataTable data = null)
        {
            double sum = 0;
            int n = (int)Math.Ceiling((b - a) / deltaX);

            for (int i = 0; i < n; i++)
            {
                double x = a + i * deltaX;
                double y = func(x);
                sum += y * deltaX;

                data?.Rows.Add(i + 1, x, y, sum);
            }
            return sum;
        }
    }
}
