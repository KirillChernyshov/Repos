using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WorkWithTxt
    {
        public static List<int> ReadingInteger(string path)
        {
            IList<string> strList = ParseFile(path);
            List<int> intList = new List<int>();

            int result;
            for (int i = 0; i < strList.Count; i++)
            {
                if (int.TryParse(strList[i], out result))
                {
                    intList.Add(result);
                }
            }

            return intList;
        }

        public static List<double> ReadingDouble(string path)
        {
            IList<string> strList = ParseFile(path);
            List<double> doubleList = new List<double>();

            double result;
            for (int i = 0; i < strList.Count; i++)
            {
                if (double.TryParse(strList[i], out result))
                {
                    doubleList.Add(result);
                }
            }

            return doubleList;
        }

        public static List<string> ReadingString(string path)
        {
            List<string> strs = File.ReadAllLines(path).ToList();

            return strs;
        }

        private static IList<string> ParseFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            string str = sr.ReadToEnd();
            sr.Close();
            IList<string> list = str.Split(' ');
            return list;
        }

        public static string ShowFile(string path)
        {
            string[] str = File.ReadAllLines(path, Encoding.UTF8);
            string text = "";

            for (int i = 0; i < str.Length; i++)
            {
                text += str[i] + "\n";
            }
            return text;
        }

        public static void Write(List<string> strs, string path)
        {
            File.WriteAllLines(path, strs);
        }
    }
}
