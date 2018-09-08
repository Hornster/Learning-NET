using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles;

namespace VisitorPatternSandbox.Visitors
{
    class CriticalHitVisitor : Visitor
    {
        public override double Visit(DamagingProjectile projectile)
        {
            return -projectile.Value * 2;
        }

        public override double Visit(HealingProjectile projectile)
        {
            return projectile.Value *1.5;
        }
    }
}
