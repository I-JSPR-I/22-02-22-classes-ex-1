using System;
using System.Collections;
using System.Collections.Generic;

namespace _22_02_22_classes_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student gegevens;
            List<Student> Studenten = new List<Student>();
           
            do
            {
                Console.Clear();
                gegevens = new Student();
                gegevens.Studentnummer++;
                Console.WriteLine("Wat is de FirstName van de Student?!");
                gegevens.FirstNameStudent = Console.ReadLine();

                Console.WriteLine("Wat is de LastName van de Student?!");
                gegevens.LastNameStudent = Console.ReadLine();

                Console.WriteLine("Wat is de Class van de Student?!");
                gegevens.ClassStudent = Console.ReadLine();

                Studenten.Add(gegevens);

                Console.WriteLine("Wilt u nog een Student toevoegen? (J/N)");
            } while (Console.ReadLine().ToUpper().Substring(0, 1) == "J");
            Console.WriteLine($"Welke Student wilt u tonen? (1 t.e.m {Studenten.Count})");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Studenten[i]}");

        }
    }
}
