using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    class Student
    {
        static private List<Student> Students = new List<Student>();
        public string FullName { get; set; }
        public DateTime Birthday { get; set; }
        public Student(string FullName,DateTime Birthday)
        {
            this.Birthday = Birthday;
            this.FullName = FullName;
            Students.Add(this);
        }
        static public string Research (string FullName)
        {
            foreach (Student St in Students)
            {
                if (St.FullName==FullName)
                {
                    return St.Birthday.ToShortDateString();
                }
            }
            throw new NullReferenceException();
        }
        
    }
}
