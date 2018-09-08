using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles;
using VisitorPatternSandbox.Visitors;

namespace VisitorPatternSandbox.Projectiles
{
    class HealingProjectile : IProjectile, IVisitable
    {
        public HealingProjectile(double value)
        {
            Value = value;
        }
        public double Value { get; private set; }

        public double Accept(Visitor visitor)
        {
            return visitor.Visit(this);
        }

        public void Shoot()
        {
            Console.WriteLine("Healing projectile has been shot!");
        }
    }
}
