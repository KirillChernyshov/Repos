using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /* Задача 1.1.29
        Дан текстовый файл NameT и файл целых чисел NameN. 
        Добавить в начало1|конец2 каждой строки файла NameT 
        изображение соответствующего числа из файла NameN. 
        Если файл NameN короче файла NameT, то оставшиеся строки
        файла NameT не изменять. 
    */
    public class AddingNumbersToText
    {
        List<int> IntList = new List<int>();

        public AddingNumbersToText(List<int> intList)
        {
            IntList = intList;
        }

        public List<string> AddTotheEnd(List<string> str)
        { 
            int count = str.Count >= IntList.Count ? IntList.Count : str.Count;

            for (int i = 0; i < count; i++)
            {
                str[i] += IntList[i];
            }

            return str;
        }

        public List<string> AddTotheBegining(List<string> str)
        {
            int count = str.Count >= IntList.Count ? IntList.Count : str.Count;

            for (int i = 0; i < count; i++)
            {
                str[i] = IntList[i] + str[i];
            }

            return str;
        }
    }
}
