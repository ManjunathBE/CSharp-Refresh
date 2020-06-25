using System;

namespace Events
{
    class Program
    {
        public static int count = 0;

        static void Main(string[] args)
        {
            Shooter shooter = new Shooter();

            shooter.ShotFired += KilledEnemy;
            shooter.ShotFired += AddScore;
            shooter.onShoot();
        }

        public static void KilledEnemy(object sender, ShotsFiredEventArgs e)
        {
            var tempSender = sender as Shooter;

            Console.WriteLine($"I killed an enemy and my name is {tempSender.Name} " );
            Console.WriteLine($"TIme of kill is {e.TimeOfKill} ");
            Console.WriteLine(count);
        }

        public static void AddScore(object sender , EventArgs e)
        {
            count++;
        }
    }
}
