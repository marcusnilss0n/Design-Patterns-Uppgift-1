using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    class Bold  :  GrundDecorator, IDecoration
    {
        public Bold(IDecoration anyDecorator)
        {
            Start = "<b>";
            End = "</b>";
            Decoration = anyDecorator;
        }
    }
}
