using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    class Smaller  :  GrundDecorator, IDecoration
    {
        public Smaller(IDecoration anyDecorator)
        {
            Start = "<small>";
            End = "</small>";
            Decoration = anyDecorator;
        }
    }
}
