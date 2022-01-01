using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    class Superscript  :  GrundDecorator, IDecoration
    {
        public Superscript(IDecoration anyDecorator)
        {
            Start = "<sup>";
            End = "</sup>";
            Decoration = anyDecorator;
        }
    }
}
