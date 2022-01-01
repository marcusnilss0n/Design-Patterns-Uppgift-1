using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.StrategyPattern
{
    public class SendSMSs  :  IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"sending \"{message}\" as a sms");
        }
    }
}
