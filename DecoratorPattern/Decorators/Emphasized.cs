using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    class Emphasized : GrundDecorator, IDecoration
    {
        public Emphasized(IDecoration anyDecorator)
        {
            Start = "<em>";
            End = "</em>";
            Decoration = anyDecorator;
        }
    }
}
