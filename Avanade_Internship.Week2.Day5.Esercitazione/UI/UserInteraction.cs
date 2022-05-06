using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using Avanade_Internship.Week2.Day5.Esercitazione.Factories;
using Avanade_Internship.Week2.Day5.Esercitazione.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.UI
{
    public static class UserInteraction
    {
        public static void Start()
        {
            var isOn = true;
            Publisher pub = new Publisher();
            List<Subscriber> subscribers = new List<Subscriber>();
            do
            {
                switch(Menu())
                {
                    case 0:
                        isOn = false;
                        break;
                    case 1:
                        // Inserisci spesa
                        
                        var expence = ExpenceFactory.GenerateExpence();
                        if (Utility.Confirmation("Confermi di voler inserire questa spesa? (Y/N)"))
                        {
                            Subscriber sub = new Subscriber(expence);
                            sub.Subscribe(pub);
                            subscribers.Add(sub);
                        }
                        break;
                    case 2:
                        // Visualizza spese
                        Console.WriteLine(UtilityFile.ReadNotProcessed().ToString());
                        break;
                    case 3:
                        // Visualizza rimborsi
                        Console.WriteLine(UtilityFile.ReadProcessed().ToString());
                        break;
                    case 4:
                        // Carica spese
                        foreach(Subscriber s in subscribers)
                        {
                            pub.Publish();
                        }
                        break;
                    case 5:
                        // Processa tutto
                        ProcessedExpenceFactory.Process();
                        
                        break;
                    default:
                        Console.WriteLine("Errore.");
                        break;
                }
            } while (isOn);
        }

        private static int Menu()
        {
            int i;
            do
            {
                Console.WriteLine("=============== Dettaglio spese ===============");
                Console.WriteLine("\nMenu:\n");
                Console.WriteLine("1. Inserisci la tua richiesta di rimborso");
                Console.WriteLine("2. Visualizza le spese da processare");
                Console.WriteLine("3. Visualizza i rimborsi elaborati");
                Console.WriteLine("4. Carica le tue richieste di rimborso");
                Console.WriteLine("5. Elabora i rimborsi");
                Console.WriteLine("\n0. Esci");
            } while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }
    }
}
