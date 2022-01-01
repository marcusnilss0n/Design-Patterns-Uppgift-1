using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    class Important  :  GrundDecorator, IDecoration
    {
        public Important(IDecoration anyDecorator)
        {
            Start = "<strong>";
            End = "</strong>";
            Decoration = anyDecorator;
        }
    }
}
