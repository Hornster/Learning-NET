using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VisitorPatternSandbox.Projectiles;
namespace VisitorPatternSandbox.Visitors
{
    abstract class Visitor
    {
        public abstract double Visit(DamagingProjectile projectile);
        public abstract double Visit(HealingProjectile projectile);
    }
}
