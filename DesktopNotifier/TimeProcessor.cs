using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace DesktopNotifier
{
    public class TimeProcessor
    {
        //!fields
        static TimeSpan day = new TimeSpan(24, 00, 00);            // for 24 hours in a day.
        static TimeSpan activationTime = new TimeSpan(8, 55, 0);   // 8:55 AM
        TimeSpan timeLeftUntilFirstRun;


        //!ctor
        public TimeProcessor()
        {
            TimeSpan now = TimeSpan.Parse(DateTime.Now.ToString("HH:mm"));   // The current time in 24 hour format
            timeLeftUntilFirstRun = (day - now) + activationTime;
        }

        //!methods

        public void Process()
        {
            if (timeLeftUntilFirstRun.TotalHours > 24)
                timeLeftUntilFirstRun -= new TimeSpan(24, 0, 0);

            Timer timer = new Timer();
            timer.Interval = timeLeftUntilFirstRun.TotalMilliseconds;
            timer.Elapsed += new ElapsedEventHandler(Timer_Notifier);  // Event to do your tasks.
            timer.Start();
        }

        //looks like all the pieces are now in place
        //I think i now need to make sure that the main window is subscribed so that it can trigger a pop-up when the event happens.

        public void Timer_Notifier(object sender, ElapsedEventArgs e)
        {
            // Do your stuff and recalculate the timer interval and reset the Timer.
        }

    }
}
