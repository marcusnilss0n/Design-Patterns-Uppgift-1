using Design_Patterns_Assignment;
using Design_Patterns_Assignment.DecoratorPattern.Decorators;
using System;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    internal class Decorator
    {
        internal static void Run()
        {
            IDecoration anyDecorator;

            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");

            Text originalDecorator = new();
            originalDecorator.TheText = Console.ReadLine();

            anyDecorator = originalDecorator;

            Console.WriteLine("Choose as Decorator");
            Console.WriteLine("1 = Bold");
            Console.WriteLine("2 = Deleted");
            Console.WriteLine("3 = Emphasized");
            Console.WriteLine("4 = Important");
            Console.WriteLine("5 = Inserted");
            Console.WriteLine("6 = Italic");
            Console.WriteLine("7 = Marked");
            Console.WriteLine("8 = Smaller");
            Console.WriteLine("9 = SubScript");
            Console.WriteLine("0 = SuperScript");
            Console.WriteLine("Q = Quit");

            ConsoleKey TextInput = new ();
            while (true)
            {
                TextInput = Console.ReadKey(intercept: true).Key;
                switch (TextInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        anyDecorator = new Bold(anyDecorator);
                        string boldstring = anyDecorator.Content();
                        Console.WriteLine(boldstring);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        anyDecorator = new Deleted(anyDecorator);
                        string deletedstring = anyDecorator.Content();
                        Console.WriteLine(deletedstring);
                        break;                        
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        anyDecorator = new Emphasized(anyDecorator);
                        string emphasizedstring = anyDecorator.Content();
                        Console.WriteLine(emphasizedstring);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        anyDecorator = new Important(anyDecorator);
                        string importantstring = anyDecorator.Content();
                        Console.WriteLine(importantstring);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        anyDecorator = new Inserted(anyDecorator);
                        string insertedstring = anyDecorator.Content();
                        Console.WriteLine(insertedstring);
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        anyDecorator = new Italic(anyDecorator);
                        string italicstring = anyDecorator.Content();
                        Console.WriteLine(italicstring);
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        anyDecorator = new Marked(anyDecorator);
                        string markedstring = anyDecorator.Content();
                        Console.WriteLine(markedstring);
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        anyDecorator = new Smaller(anyDecorator);
                        string smallerstring = anyDecorator.Content();
                        Console.WriteLine(smallerstring);
                        break;
                    case ConsoleKey.D9:
                    case ConsoleKey.NumPad9:
                        anyDecorator = new Subscript(anyDecorator);
                        string subscriptstring = anyDecorator.Content();
                        Console.WriteLine(subscriptstring);
                        break;
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        anyDecorator = new Superscript(anyDecorator);
                        string superscriptstring = anyDecorator.Content();
                        Console.WriteLine(superscriptstring);
                        break;
                    case ConsoleKey.Q:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}