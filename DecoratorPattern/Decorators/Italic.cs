using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    class Italic  :  GrundDecorator, IDecoration
    {
        public Italic(IDecoration anyDecorator)
        {
            Start = "<i>";
            End = "</i>";
            Decoration = anyDecorator;
        }
    }
}
