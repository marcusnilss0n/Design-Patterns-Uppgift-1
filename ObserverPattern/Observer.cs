using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    class Observer
    {
        internal static void Run()
        {
            Subject subject = new();
            int numberOfParents = 5;

            List<Observers> observerList = new();

            for (int i = 0; i < 4; i++)
            {
                Observers observers = new();
                subject.AddObservers(observers);
                observerList.Add(observers);
            }

            for (int i = 0; i < numberOfParents; i++)
            {
                Parent parent = new();
                subject.AddObservers(parent);
            }

            subject.IsItTime();

            for (int i = 0; i < numberOfParents; i++)
            {
                if (observerList.Count > 0)
                {
                    var O = observerList.First();
                    subject.DeleteObservers(O);
                    observerList.Remove(O);
                }
            }

            subject.IsItTime();
        }    
    }
}
 
