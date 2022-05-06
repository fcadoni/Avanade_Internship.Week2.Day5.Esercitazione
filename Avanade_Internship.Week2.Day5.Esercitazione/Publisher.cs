using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione
{
    public class Publisher
    {
        

        public delegate void Notify(Publisher p);

        public event Notify OnPublish;

        public void Publish()
        {
            if (OnPublish != null)
            {
                OnPublish(this);
            }
        }

    }
}
