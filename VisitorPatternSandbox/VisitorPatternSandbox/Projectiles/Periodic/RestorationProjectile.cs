using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles.Periodic;
using VisitorPatternSandbox.Visitors;
using VisitorPatternSandbox.Visitors.Periodic;

namespace VisitorPatternSandbox.Projectiles.Periodic
{
    class RestorationProjectile : PeriodicProjectile
    {
        public RestorationProjectile(double value, double durationTime)
            : base(value, durationTime) { }

        public override double Accept(PeriodicVisitor visitor, ref double duration)
        {
            return visitor.Visit(this, ref duration);
        }

        public override void Shoot()
        {
            Console.WriteLine("Restoration HoT has been shot!");
        }
    }
}
