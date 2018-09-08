using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles.Periodic;

namespace VisitorPatternSandbox.Visitors.Periodic
{
    class RegularPeriodicVisitor : PeriodicVisitor
    {
        public override double Visit(RestorationProjectile projectile, ref double duration)
        {
            duration = projectile.DurationTime;
            return projectile.Value;
        }

        public override double Visit(PoisonProjectile projectile, ref double duration)
        {
            duration = projectile.DurationTime;
            return -projectile.Value;
        }
    }
}
