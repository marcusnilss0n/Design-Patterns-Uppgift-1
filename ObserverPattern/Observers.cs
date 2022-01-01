using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.ObserverPattern
{
    class Observers  :  IObservers
    {
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
