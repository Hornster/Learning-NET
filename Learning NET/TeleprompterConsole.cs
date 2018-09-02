using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace TelepromterConsole
{
    internal class TeleprompterConfig
    {
        private object lockHandle = new object();
        public int DelayInMiliseconds { get; private set; } = 200;

        public void UpdateDelay(int increment) //negative to speed up
        {
            var newDelay = Min(DelayInMiliseconds + increment, 1000);
            newDelay = Max(newDelay, 20);

            lock(lockHandle)
            {
                DelayInMiliseconds = newDelay;
            }
        }

        public bool Done { get; private set; }
        public void SetDone()
        {
            Done = true;
        }
    }
}
