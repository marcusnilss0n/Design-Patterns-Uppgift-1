using System;

namespace Design_Patterns_Assignment.StrategyPattern
{
    public class Strategy
    {
        public static void Run()
        {
            Console.WriteLine("Strategy");
            Console.WriteLine("Choose an option");
            Console.WriteLine("1. Send via Email");
            Console.WriteLine("2. Send via SMS");
            Console.WriteLine("3. Send via Facebook");

            var message = "This is the message";

            MessageHandler messageHandler = new();            
            SendEmails sendEmails = new();
            SendSMSs sendSMSs = new();
            SendFacebookMessages sendFaceBookMessages = new();

            while (true)
            {
                var userInput = Console.ReadKey(true).Key;

                switch (userInput)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        messageHandler.SendMessages = sendEmails;
                        messageHandler.Send(message);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        messageHandler.SendMessages = sendSMSs;
                        messageHandler.Send(message);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        messageHandler.SendMessages = sendFaceBookMessages;
                        messageHandler.Send(message);
                        break;

                }
            }
        }
    }
}