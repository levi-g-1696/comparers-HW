using System;
using System.Collections.Generic;

namespace comparers_hw_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("      Students sort");
            List<Student> group = new List<Student>()  ;
            group.Add(new Student("Nuriel","Rabinovic",78));
            group.Add(new Student("David","Lipkovic",79));
            group.Add(new Student("Miriam","Rabinovic",91));
            group.Add(new Student("Ofir","Ohana",88));
            group.Add(new Student("Asaf","Alkayam",78));
            PrintGroup(group);
            Console.WriteLine("    after sorting:");
            group.Sort();
            PrintGroup(group);
            Console.WriteLine("    after sorting:");

            group.Sort(new SortStudentsByGrade());
            PrintGroup(group);
            Console.WriteLine("    after sorting:");

            group.Sort(new SortStudentsLastFirstName());
            PrintGroup(group);
            group.Sort(new SortStudentsLastFirstNameGrade());
            PrintGroup(group);
            ManageMeasurments mm = new ManageMeasurments();
            mm.TestSortig();
            Console.WriteLine();



            static void PrintGroup(List<Student> studList)
            {
                foreach (var student in studList)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }

}
