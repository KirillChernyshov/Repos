using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    /* Задача 1.3.14
        Вывести студента с наименьшим средним баллом на каждом курсе.
    */
    public class SortOfStudents
    {
        public Student[] Students { get; set; }

        public SortOfStudents(Student[] students)
        {
            Students = students;
        }

        public IList<Student> StudetsWithMinMark()
        {
            List<Student> students = new List<Student>();

            var q = Students.GroupBy(s => s.Course).GroupBy(f => f.Where(d => d.AverageRating == f.Min(l => l.AverageRating)));

            foreach (var i in q)
            {
                students.Add(i.Key.Last());
            }

            return students;
        }
    }
}
