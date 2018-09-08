using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles;

namespace VisitorPatternSandbox.Characters
{
    interface ICharacter
    {
        void ReceiveHit(double value);
        void AddEffect(double valuePerTick, double duration);
    }
}
