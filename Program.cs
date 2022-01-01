using Design_Patterns_Assignment;
using Design_Patterns_Assignment.DecoratorPattern;
using Design_Patterns_Assignment.ObserverPattern;
using Design_Patterns_Assignment.RepositoryPattern;
using Design_Patterns_Assignment.StrategyPattern;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Decorator.Run();
            Repository.Run();
            Strategy.Run();
            Observer.Run();
        }     
    }
}
