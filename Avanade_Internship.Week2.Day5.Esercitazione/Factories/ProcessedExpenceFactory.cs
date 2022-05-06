using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using Avanade_Internship.Week2.Day5.Esercitazione.Handler;
using Avanade_Internship.Week2.Day5.Esercitazione.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.Factories
{
    public static class ProcessedExpenceFactory
    {
        public static void Process()
        {
            var list = Util.UtilityFile.ReadNotProcessed();

            foreach (var item in list)
            {
                var processing = ProcessExpence(item);
                Util.UtilityFile.SaveToFile(processing.ToRow());
            }
            Console.WriteLine("\nSalvataggio Completato.\n");
        }

        private static ProcessedExpence ProcessExpence(Expence exp)
        {
            ProcessedExpence processed = (ProcessedExpence)exp;
            IHandler manager = new Manager();
            IHandler ops = new OperationalManager();
            IHandler ceo = new CEO();

            manager.SetNext(ops.SetNext(ceo));

            processed.LvlApproved = manager.Handle(processed.Amount);

            if (processed.LvlApproved != Level.none)
            {

                switch (exp.Rating)
                {
                    case Category.Viaggio:
                        processed.RefundAmount = processed.Amount + 5;
                        break;
                    case Category.Alloggio:
                        processed.RefundAmount = processed.Amount;
                        break;
                    case Category.Vitto:
                        processed.RefundAmount = processed.Amount * 0.7;
                        break;
                    default:
                        processed.RefundAmount = processed.Amount * 0.1;
                        break;
                }
            }

            return processed;
        }
    }
}
