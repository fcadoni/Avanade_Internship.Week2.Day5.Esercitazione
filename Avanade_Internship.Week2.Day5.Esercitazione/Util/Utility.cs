using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.Util
{
    public static class Utility
    {
        //Prende una stringa in ingresso che viene stampata a video e
        //crea un ciclo da cui non esce finchè l'utente non inserisce
        //'y' o 'n' in risposta.
        //Restituisce true se la risposta è y, false se è n
        public static bool Confirmation(string choice)
        {
            string input = null;
            do
            {
                if (input != null)
                {
                    Console.WriteLine("Inserisci una risposta valida.\n");
                }
                Console.WriteLine(choice);
                input = Console.ReadLine();
            } while (string.Compare("y", input.ToLower()) != 0 && string.Compare("n", input.ToLower()) != 0);
            return string.Compare("y", input.ToLower()) == 0;
        }
    }
}
