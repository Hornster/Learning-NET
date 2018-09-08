using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles.Periodic;

namespace VisitorPatternSandbox.Visitors.Periodic
{
    abstract class PeriodicVisitor
    {
        public abstract double Visit(RestorationProjectile projectile, ref double duration);
        public abstract double Visit(PoisonProjectile projectile, ref double duration);
    }
}
