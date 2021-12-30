using System;
using System.Globalization;
using System.Collections.Generic;
using ExercInheritanceAbs2.Entities;

namespace ExercInheritanceAbs2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer {i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Heath expenditures: ");
                    double healthCharges = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healthCharges));
                }
                else if (ch == 'c')
                {
                    Console.Write("Number of employees? ");
                    int empNumber = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, empNumber));
                }
            }
           
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach (TaxPayer tpayer in list)
            {
                Console.WriteLine($"{tpayer.Name}: $ {tpayer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tpayer.TaxesPaid();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: {sum.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
