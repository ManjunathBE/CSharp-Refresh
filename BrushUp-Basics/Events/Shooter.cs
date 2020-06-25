using System;
using System.Threading;

namespace Events
{
    public class Shooter
    {
        private Random rng = new Random();

        public delegate void ShootingHandler(object sender, ShotsFiredEventArgs e);

        public event ShootingHandler ShotFired;

        public string Name { get; set; } = "Billy";
        public void onShoot()
        {
            while (true)
            {
                if(rng.Next(0,100) % 2 == 0)
                {
                    if(ShotFired != null)
                    {
                        ShotFired.Invoke(this, new ShotsFiredEventArgs() { TimeOfKill = DateTime.Now });
                    }
                }
                else
                {
                    Console.WriteLine("I missed");
                }
                Thread.Sleep(500);
            }
        }
    }
}
