using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.Entities
{
    public enum Level
    {
        MGR,
        OPS,
        CEO,
        none
    }
    public class ProcessedExpence : Expence
    {
        public bool IsApproved { get; set; }
        public Level LvlApproved { get; set; }
        public double RefundAmount { get; set; }

        public string ApprovedOrNot()
        {
            return IsApproved ? "APPROVATO" : "NON APPROVATO";
        }

        public override string ToRow()
        {
            return $"{base.ToRow()};{IsApproved};{LvlApproved};{RefundAmount}";
        }
        public override string ToString()
        {
            return  base.ToString() +
                    $"Stato: {ApprovedOrNot()}\n" +
                    $"Livello: {LvlApproved}\n" +
                    $"Importo rimborsato: €{RefundAmount}\n";
        }
    }
}
