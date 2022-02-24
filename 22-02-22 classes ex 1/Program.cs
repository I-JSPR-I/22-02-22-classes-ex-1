using System;
using System.Collections;
using System.Collections.Generic;

namespace _22_02_22_classes_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Data;
            List<Student> students = new List<Student>();
           
            do
            {
                Console.Clear();
                Data = new Student();
                Console.WriteLine("What is the first name of the student?");
                Data.FirstNameStudent = Console.ReadLine();

                Console.WriteLine("What is the last name of the student?");
                Data.LastNameStudent = Console.ReadLine();

                Console.WriteLine("What class is the student in?");
                Data.ClassStudent = Console.ReadLine();

                students.Add(Data);

                Console.WriteLine("Do you want to add another student? (Y/N)");
            } while (Console.ReadLine().ToUpper().Substring(0, 1) == "Y");
            Console.WriteLine($"Which student do you want to see? (between 1 and {students.Count})");
            int i = Convert.ToInt32(Console.ReadLine());
            i++;
            Console.WriteLine($"{students[i].FirstNameStudent}");
            Console.WriteLine($"{students[i].LastNameStudent}");
            Console.WriteLine($"{students[i].ClassStudent}");

        }
    }
}
