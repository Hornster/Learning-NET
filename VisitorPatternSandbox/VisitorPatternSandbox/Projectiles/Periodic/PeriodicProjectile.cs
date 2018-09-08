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
    abstract class PeriodicProjectile : IPeriodicProjectile, IPeriodicVisitable
    {
        public PeriodicProjectile(double value, double durationTime)
        {
            DurationTime = durationTime;
            Value = value;
        }
        public double Value { get; private set; }

        public double DurationTime { get; private set; }
        
        public abstract void Shoot();

        public abstract double Accept(PeriodicVisitor visitor, ref double duration);
    }
}
