using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_tech
{
    public class Calculator
    {
        public static double Calculation(List<double> numbers, List<char> operations)
        {
            Stack<double> stack = new Stack<double>();
            stack.Push(numbers[0]);

            int opIndex = 0;
            for (int i = 1; i < numbers.Count; i++)
            {
                stack.Push(numbers[i]);

                if (opIndex < operations.Count)
                {
                    double b = stack.Pop();
                    double a = stack.Pop();
                    double res = MakeOperation(a, b, operations[opIndex]);
                    stack.Push(res);
                    opIndex++;
                }
            }

            return stack.Pop();
        }

        private static double MakeOperation(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0) throw new DivideByZeroException();
                    return a / b;
                default:
                    throw new ArgumentException("Неизвестная операция");
            }
        }
    }
}
