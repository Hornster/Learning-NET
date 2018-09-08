using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles;
using VisitorPatternSandbox.Projectiles.Periodic;

namespace VisitorPatternSandbox.Visitors
{
    class RegularHitVisitor : Visitor
    {
        public override double Visit(DamagingProjectile projectile)
        {
            return -projectile.Value;
        }

        public override double Visit(HealingProjectile projectile)
        {
            return projectile.Value;
        }
    }
}
