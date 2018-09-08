using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VisitorPatternSandbox.Projectiles
{
    interface IProjectile 
    {
        /// <summary>
        /// Value assigned to this projectile.
        /// </summary>
        double Value { get; }
        /// <summary>
        /// Fire projectile.
        /// </summary>
        void Shoot();
    }
}
