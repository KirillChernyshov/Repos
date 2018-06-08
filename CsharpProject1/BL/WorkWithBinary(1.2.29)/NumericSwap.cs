using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /* Задача 1.2.29
        Дан файл вещественных чисел. 
        Поменять в нем местами минимальный и максимальный элементы.
    */
    public class NumericSwap
    {
        public List<double> Array { get; set; }

        public NumericSwap(List<double> dList)
        {
            Array = dList;
        }

        public List<double> SwapMinMax()
        {
            double max = Array.Max();
            double min = Array.Min();

            int maxIndex = Array.IndexOf(max);
            int minIndex = Array.IndexOf(min);

            Array[maxIndex] = min;
            Array[minIndex] = max;

            return Array;
        }
    }
}
