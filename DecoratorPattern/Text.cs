using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    class Text  :  IDecoration
    {
        public string TheText { get; set; }
        public Text()
        {

        }
        public string Content()
        {
            return TheText;
        }
    }
}
