using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles.Periodic;

namespace VisitorPatternSandbox.Visitors.Periodic
{
    class OverpowPeriodicVisitor : PeriodicVisitor
    {
        public override double Visit(RestorationProjectile projectile, ref double duration)
        {
            duration = projectile.DurationTime * 1.5;
            return projectile.Value*1.4;
        }

        public override double Visit(PoisonProjectile projectile, ref double duration)
        {
            duration = projectile.DurationTime * 1.25;
            return -projectile.Value * 1.8;
        }
    }
}
