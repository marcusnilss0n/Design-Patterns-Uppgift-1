using System;

namespace Design_Patterns_Assignment.StrategyPattern
{
    internal class MessageHandler
    {
        public IMessageSender SendMessages { get; set; }

        public void Send(string message)
        {
            SendMessages.SendMessage(message);
        }
    }
}