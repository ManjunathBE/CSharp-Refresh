using System;
using System.Threading;

namespace Events
{
    public class Shooter
    {
        private Random rng = new Random();


        public event EventHandler<ShotsFiredEventArgs> ShotFired;

        public string Name { get; set; } = "Billy";
        public void onShoot()
        {
            while (true)
            {
                if(rng.Next(0,100) % 2 == 0)
                {
                     
                        ShotFired?.Invoke(this, new ShotsFiredEventArgs() { TimeOfKill = DateTime.Now });
                    
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
