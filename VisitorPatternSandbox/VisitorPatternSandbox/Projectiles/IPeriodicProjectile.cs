using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPatternSandbox.Projectiles
{
    interface IPeriodicProjectile: IProjectile
    {
        /// <summary>
        /// Returns the duration time (in seconds) of the effect
        /// </summary>
        double DurationTime { get; }

    }
}
