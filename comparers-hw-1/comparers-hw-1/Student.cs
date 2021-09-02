using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparers_hw_1
{
    class Student : IComparable<Student>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public Student(string firstName, string lastName, int grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public Student()
        {
        }


        public override string ToString()
        {
            string studentProp = $"Student: {this.LastName} {this.FirstName}.\t Grade:{this.Grade}";
            return studentProp;
        }

        public int CompareTo(Student? student)
        {
            return this.LastName.CompareTo(student.LastName);
        }


    }
    class SortStudentsByGrade : IComparer<Student>
    {
        public int Compare(Student? s1, Student? s2)
        {
            return (s1.Grade.CompareTo(s2.Grade) * -1);
        }
    }

    class SortStudentsLastFirstName : IComparer<Student>
    {
        public int Compare(Student? s1, Student? s2)
        {
            if (s1.LastName.CompareTo(s2.LastName) == 0)
            {

                if (s1.FirstName.CompareTo(s2.FirstName) <= 0) return -1;
                else return 1;

            }

            else return (s1.LastName.CompareTo(s2.LastName));
        }
    }
    class SortStudentsLastFirstNameGrade : IComparer<Student>
    {
        public int Compare(Student? s1, Student? s2)
        {
            if (s1.LastName.CompareTo(s2.LastName) == 0)
            {

                if (s1.FirstName.CompareTo(s2.FirstName) < 0) return -1;
                else if (s1.Grade.CompareTo(s2.Grade) < 0) return -1;
                      else return 1;
            }

            else return (s1.LastName.CompareTo(s2.LastName));
        }
    }
}
