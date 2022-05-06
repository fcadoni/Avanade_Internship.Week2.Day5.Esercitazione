using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using Avanade_Internship.Week2.Day5.Esercitazione.Handler;
using Avanade_Internship.Week2.Day5.Esercitazione.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.Util
{
    public static class UtilityFile
    {
        private const string FilesPath = @"C:\Users\fcado\source\repos\Avanade_Internship\Week2\Day5\Avanade_Internship.Week2.Day5.Esercitazione\Avanade_Internship.Week2.Day5.Esercitazione\Database\";
        public const string ProcessedPath = FilesPath + "spese_elaborate.txt";
        public const string UnprocessedPath = FilesPath + "spese.txt";
        public static List<Expence> ReadNotProcessed()
        {
            List<Expence> list = new List<Expence>();

            StreamReader sr = new StreamReader(UnprocessedPath);
            var backup = sr.ReadToEnd().Split("\r\n");
            sr.Close();
            foreach (var line in backup)
            {
                var lineFields = line.Split(';');

                DateTime.TryParse(lineFields[0], out DateTime date);
                var cat = Category.TryParse(lineFields[1], out Category category);
                var amount = double.TryParse(lineFields[3], out double cost);

                var c = new Expence()
                {
                    Date = date,
                    Rating = category,
                    Description = lineFields[2],
                    Amount = cost
                };
                list.Add(c);
            }
            return list;
        }
        public static List<Expence> ReadProcessed()
        {
            List<Expence> list = new List<Expence>();

            StreamReader sr = new StreamReader(ProcessedPath);
            var backup = sr.ReadToEnd().Split("\r\n");
            sr.Close();

            foreach (var line in backup)
            {
                var lineFields = line.Split(';');

                DateTime.TryParse(lineFields[0], out DateTime date);
                Category.TryParse(lineFields[1], out Category category);
                double.TryParse(lineFields[3], out double cost);
                bool.TryParse(lineFields[4], out bool isApproved);
                Level.TryParse(lineFields[5], out Level level);
                double.TryParse(lineFields[6], out double refund); 

                var c = new ProcessedExpence()
                {
                    Date = date,
                    Rating = category,
                    Description = lineFields[2],
                    Amount = cost,
                    IsApproved = isApproved,
                    LvlApproved = level,
                    RefundAmount = refund
                };
                list.Add(c);
            }
            return list;
        }

        public static void SaveToFile(string exp)
        {
            var path = (exp is ProcessedExpence) ? ProcessedPath : UnprocessedPath;
            StreamWriter sw =  new StreamWriter(path, true);
            
            sw.WriteLine(exp);
            sw.Close();
        }
    }
}
