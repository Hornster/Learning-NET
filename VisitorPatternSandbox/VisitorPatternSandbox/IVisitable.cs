using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Visitors;
using VisitorPatternSandbox.Visitors.Periodic;

namespace VisitorPatternSandbox
{
    interface IVisitable
    {
        double Accept(Visitor visitor);
    }
}

namespace VisitorPatternSandbox
{
    interface IPeriodicVisitable
    {
        double Accept(PeriodicVisitor visitor, ref double duration);
    }
}
