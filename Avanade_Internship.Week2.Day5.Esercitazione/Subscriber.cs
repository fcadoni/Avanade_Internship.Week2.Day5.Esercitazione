using Avanade_Internship.Week2.Day5.Esercitazione.Entities;
using Avanade_Internship.Week2.Day5.Esercitazione.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanade_Internship.Week2.Day5.Esercitazione
{
    public class Subscriber
    {
        public Expence Exp;

        public Subscriber(Expence expence)
        {
            Exp = expence;
        }

        
        public void Subscribe(Publisher p)
        {
            //registrazione all'evento di notifica
            p.OnPublish += OnNotificationReceived;
        }

        public void UnSubscribe(Publisher p)
        {
            p.OnPublish -= OnNotificationReceived;
        }

        

        public void OnNotificationReceived(Publisher p)
        {
            UtilityFile.SaveToFile(Exp.ToRow());
        }
    }
}
