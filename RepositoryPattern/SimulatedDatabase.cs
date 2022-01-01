using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    public static class SimulatedDatabase
    {
        public static string Load(string inputString)
        {
            return inputString;
        }

        public static void Save(string data)
        {
            Console.WriteLine($"Saving data \"{data}\"");
        }
    }
}
