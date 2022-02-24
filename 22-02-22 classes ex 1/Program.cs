using System;
using System.Collections;
using System.Collections.Generic;

namespace _22_02_22_classes_ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Leerling gegevens;
            List<Leerling> leerlingen = new List<Leerling>();
           
            do
            {
                Console.Clear();
                gegevens = new Leerling();
                gegevens.Leerlingnummer++;
                Console.WriteLine("Wat is de voornaam van de leerling?!");
                gegevens.VoorNaamLeerling = Console.ReadLine();

                Console.WriteLine("Wat is de achternaam van de leerling?!");
                gegevens.AchterNaamLeerling = Console.ReadLine();

                Console.WriteLine("Wat is de klas van de leerling?!");
                gegevens.Klasleerling = Console.ReadLine();

                leerlingen.Add(gegevens);

                Console.WriteLine("Wilt u nog een leerling toevoegen? (J/N)");
            } while (Console.ReadLine().ToUpper().Substring(0, 1) == "J");
            Console.WriteLine($"Welke leerling wilt u tonen? (1 t.e.m {leerlingen.Count})");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{leerlingen[i]}");

        }
    }
}
