using Design_Patterns_Assignment;

using System;

namespace Design_Patterns_Assignment.RepositoryPattern
{
    internal class Repository
    {
        internal static void Run()
        {
           // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");
            DataRepository dataRepository = new();

            
            var data = dataRepository.GetAllData("Dataset A");
            var customer = dataRepository.GetAllData("From Table Customer Where Name==Steve");
            var animal = dataRepository.GetAllData("From Table Animal Where Owner==Steve");

            dataRepository.SaveData(data);
            dataRepository.SaveData(customer);
            dataRepository.SaveData(animal);

            Console.WriteLine();

           
        }
    }
}