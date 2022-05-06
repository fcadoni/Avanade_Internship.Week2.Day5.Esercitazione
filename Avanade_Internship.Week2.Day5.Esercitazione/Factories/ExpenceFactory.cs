using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.Factories
{
    public static class ExpenceFactory
    {
        public static Expence GenerateExpence()
        {
            return new Expence()
            {
                Date = GetDate(),
                Rating = GetCategory(),
                Amount = GetAmount(),
                Description = GetDescription()
            };
        }

        private static DateTime GetDate()
        {
            DateTime date;
            int day, month, year;
            do
            {
                Console.WriteLine("Spesa effettuata il");
                Console.WriteLine("Giorno");
                Console.WriteLine("Mese");
                Console.WriteLine("Anno");

                do { }

            } while (DateTime.TryParse(Console.ReadLine(), out date));
            return date;
        }

        private static double GetAmount()
        {
            double amount;
            do
            {
                Console.WriteLine("A quanto ammonta la spesa?");

            } while (double.TryParse(Console.ReadLine(), out amount));
            return amount;
        }
        private static Category GetCategory()
        {
            Category category;
            do
            {
                Console.WriteLine("Specifica la categoria della tua spesa:");
                Console.WriteLine("Viaggio = 1");
                Console.WriteLine("Alloggio = 2");
                Console.WriteLine("Vitto = 3");
                Console.WriteLine("Altro = 4");

            } while (Category.TryParse(Console.ReadLine(), out category));
            return category;
        }
        private static string GetDescription()
        {
            Console.WriteLine("Descrivi brevemente la spesa:");
            return Console.ReadLine();
        }
    }
}
