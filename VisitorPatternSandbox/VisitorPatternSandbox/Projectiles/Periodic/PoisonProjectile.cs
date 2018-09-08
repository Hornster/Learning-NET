using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles.Periodic;
using VisitorPatternSandbox.Visitors.Periodic;

namespace VisitorPatternSandbox.Projectiles.Periodic
{
    class PoisonProjectile : PeriodicProjectile
    {
        public PoisonProjectile(double value, double durationTime)
            : base(value, durationTime) { }

        public override double Accept(PeriodicVisitor visitor, ref double duration)
        {
            return visitor.Visit(this, ref duration);
        }

        public override void Shoot()
        {
            Console.WriteLine("Poisonous DoT has been shot!");
        }
    }
}
