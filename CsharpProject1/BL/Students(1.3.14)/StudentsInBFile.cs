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
        string Path { get; set; }

        public StudentsInBFile(string path)
        {
            Path = path;
        }

        public void Write(Student[] students)
        {
            BinaryFormatter formatter = new BinaryFormatter();
                
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, students);
            }
        }

        public Student[] Read()
        {
            Student[] students;
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                students = (Student[])formatter.Deserialize(fs);
            }

            return students;
        }
    }
}
