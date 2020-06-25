using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class ShotsFiredEventArgs : EventArgs
    {
        public DateTime TimeOfKill { get; set; }
        public ShotsFiredEventArgs(DateTime time)
        {
            this.TimeOfKill = time;
        }
        public ShotsFiredEventArgs()
        {

        }
    }
}
