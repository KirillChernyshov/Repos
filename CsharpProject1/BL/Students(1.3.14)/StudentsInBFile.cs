using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class StudentsInBFile
    {
        public static void Write(Student[] students, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
                
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
            }
        }

        public static Student[] Read(string path)
        {
            Student[] students;
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                students = (Student[])formatter.Deserialize(fs);
            }

            return students;
        }
    }
}
