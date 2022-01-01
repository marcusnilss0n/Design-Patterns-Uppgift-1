using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern.Decorators
{
    class Deleted  :  GrundDecorator, IDecoration
    {
        public Deleted(IDecoration anyDecorator)
        {
            Start = "<del>";
            End = "</del>";
            Decoration = anyDecorator;
        }
    }
}
