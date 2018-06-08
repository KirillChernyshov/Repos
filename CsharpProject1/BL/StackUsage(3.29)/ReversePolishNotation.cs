using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /* Задача 3.1.29
        Написать программу для вычисления значения выражения, 
        представленного в обратной польской записи.
    */
    public class ReversePolishNotation
    {
        string Expression { get; set; }

        public ReversePolishNotation(string expression)
        {
            Expression = expression;
        }

        public double HandlerOfExpression()
        {
            string[] elements = Expression.Split(' ');
            Stack operands = new Stack();

            for (int i = 0; i < elements.Length; i++)
            {
                double val;
                if (double.TryParse(elements[i], out val))
                {
                    operands.Push(val);
                }
                else
                {
                    double result = DoOperation((double)operands.Get(), (double)operands.Get(), elements[i]);
                    operands.Push(result);
                }
            }

            return (double)operands.Get();
        }

        double DoOperation(double a, double b, string op)
        {
            double result;
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = b - a;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    if (a != 0)
                        result = b / a;
                    else
                        result = 0;
                    break;
                default:
                    result = 0;
                    break;
            }

            return result;
        }
    }
}
