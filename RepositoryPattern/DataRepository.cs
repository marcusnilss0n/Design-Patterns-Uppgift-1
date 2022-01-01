using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    class DataRepository  :  IDataRepository
    {
        public string GetAllData(string inputString)
        {
           return SimulatedDatabase.Load(inputString);
        }

        public void SaveData(string data)
        {
            SimulatedDatabase.Save(data);
        }

    }    
}
