using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class WorkWithBFile
    {
        public static List<double> ReadOfDouble(string path)
        {
            List<double> array = new List<double>();

            if (File.Exists(path))
            {
                FileStream streamer = new FileStream(path, FileMode.Open);

                using (BinaryReader reader = new BinaryReader(streamer))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        array.Add(reader.ReadDouble());
                    }
                }

            }
            return array;
        }

        public static void WriteOfDouble(IList<double> arr, string path)
        {
            FileStream sr = new FileStream(path, FileMode.OpenOrCreate);

            using (BinaryWriter writer = new BinaryWriter(sr))
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    writer.Write(arr[i]);
                }
            }
        }
    }
}
