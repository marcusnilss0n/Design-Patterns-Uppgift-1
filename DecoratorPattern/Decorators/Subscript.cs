using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    class Subscript  :  GrundDecorator, IDecoration
    {
        public Subscript(IDecoration anyDecorator)
        {
            Start = "<sub>";
            End = "</sub>";
            Decoration = anyDecorator;
        }
    }
}
