using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPatternSandbox.Characters;
using VisitorPatternSandbox.Projectiles;
using VisitorPatternSandbox.Projectiles.Periodic;
using VisitorPatternSandbox.Visitors;
using VisitorPatternSandbox.Visitors.Periodic;

namespace VisitorPatternSandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            PeriodicVisitor pNormalVisitor = new RegularPeriodicVisitor();
            PeriodicVisitor pCritVisitor = new OverpowPeriodicVisitor();
            Visitor normalVisitor = new RegularHitVisitor();
            Visitor criticalVisitor = new CriticalHitVisitor();

            ICharacter character = new Character();
            DamagingProjectile dProj1 = new DamagingProjectile(5);
            DamagingProjectile dProj2 = new DamagingProjectile(7);
            HealingProjectile hProj1 = new HealingProjectile(4);
            PoisonProjectile pProj1 = new PoisonProjectile(2.5, 10);
            RestorationProjectile rProj1 = new RestorationProjectile(3, 8);

            double duration = 0.0, value = 0.0;
            dProj1.Shoot();
            character.ReceiveHit(dProj1.Accept(normalVisitor));
            character.ReceiveHit(dProj1.Accept(criticalVisitor));

            hProj1.Shoot();
            character.ReceiveHit(hProj1.Accept(normalVisitor));
            character.ReceiveHit(hProj1.Accept(criticalVisitor));

            pProj1.Shoot();
            value = pProj1.Accept(pNormalVisitor, ref duration);
            character.AddEffect(value, duration);
            value = pProj1.Accept(pCritVisitor, ref duration);
            character.AddEffect(value, duration);

            rProj1.Shoot();
            value = rProj1.Accept(pNormalVisitor, ref duration);
            character.AddEffect(value, duration);
            value = rProj1.Accept(pCritVisitor, ref duration);
            character.AddEffect(value, duration);

            Console.ReadKey();
        }
    }
}
