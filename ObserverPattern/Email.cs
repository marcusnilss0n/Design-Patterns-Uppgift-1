using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment.ObserverPattern
{
    public class Email
    {
       internal static string Check()
       {
           var evenMinute = DateTime.Now.Minute % 2;
           if (evenMinute==0)
           {
              return "this is the email";
           }
          return null;
       }
    }
}