using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    internal class Subject
    {
        internal void IsItTime()
        {
            int evenMinute = 0;
            while (true)
            {
                evenMinute = DateTime.Now.Second % 10;
                Thread.Sleep(1000);
                if (evenMinute == 0)
                {
                    foreach (var observers in ListOfObservers)
                    {
                        observers.Notify("Dags för Rast");
                    }
                    break;               
                } 
            }
        }

        private List<IObservers> ListOfObservers { get; set; }

        public Subject()
        {
            ListOfObservers = new List<IObservers>();
        }
        public void AddObservers(IObservers Observers)
        {
            ListOfObservers.Add(Observers);
        }
        public void DeleteObservers(IObservers Observers)
        {
            ListOfObservers.Remove(Observers);
        }
    }
}
