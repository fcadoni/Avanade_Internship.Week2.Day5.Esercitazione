using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using Avanade_Internship.Week2.Day5.Esercitazione.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.Handler
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler next;

        public virtual Level Handle(double richiesta)
        {
            if(next != null)
                return next.Handle(richiesta);
            else
                return Level.none;
        }

        public IHandler SetNext(IHandler handler)
        {
            next = handler;
            return handler;
        }
    }
}
