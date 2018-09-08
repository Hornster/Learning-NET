using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Projectiles;

namespace VisitorPatternSandbox.Characters
{
    class Character : ICharacter
    {
        public void ReceiveHit(double value)
        {
            Console.WriteLine($"Received hit for { value }!");
        }

        public void AddEffect(double valuePerTick, double duration)
        {
            Console.WriteLine($"New effect acquired: { valuePerTick } for { duration } seconds!");
        }
    }
}
