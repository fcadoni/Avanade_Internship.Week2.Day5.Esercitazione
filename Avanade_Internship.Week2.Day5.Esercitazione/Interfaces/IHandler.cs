using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        Level Handle(double richiesta);
    }
}
