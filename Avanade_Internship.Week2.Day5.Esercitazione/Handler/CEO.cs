using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.Handler
{
    public class CEO : AbstractHandler
    {
        public override Level Handle(double richiesta)
        {
            if (richiesta <= 2500.0)
                return Level.CEO;
            else
                return base.Handle(richiesta);
        }
    }
}
