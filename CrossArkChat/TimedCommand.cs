namespace CrossArkChat
{
    using System;
    using System.Collections.Generic;

    public class TimedCommand
    {
        public void UpdateNextRunTime()
        {
            if (!this.Active || (this.Timespan <= 0))
            {
                this.NextRunTime = DateTime.MaxValue;
            }
            else
            {
                DateTime nextRunTime;
                string str = this.Frequency.ToLower();
                if (str == "minute")
                {
                    if (this.NextRunTime == DateTime.MaxValue)
                    {
                        this.NextRunTime = DateTime.get_Today().Add(this.TimeOffset);
                    }
                    while (this.NextRunTime < DateTime.get_Now())
                    {
                        nextRunTime = this.NextRunTime;
                        this.NextRunTime = nextRunTime.AddMinutes((double)this.Timespan);
                    }
                }
                else if (str == "hour")
                {
                    if (this.NextRunTime == DateTime.MaxValue)
                    {
                        this.NextRunTime = DateTime.get_Today().Add(this.TimeOffset);
                    }
                    while (this.NextRunTime < DateTime.get_Now())
                    {
                        nextRunTime = this.NextRunTime;
                        this.NextRunTime = nextRunTime.AddHours((double)this.Timespan);
                    }
                }
                else if (str == "day")
                {
                    if (this.NextRunTime == DateTime.MaxValue)
                    {
                        this.NextRunTime = DateTime.get_Today().Add(this.TimeOffset);
                    }
                    while (this.NextRunTime < DateTime.get_Now())
                    {
                        this.NextRunTime = this.NextRunTime.AddDays((double)this.Timespan);
                    }
                }
            }
        }

        public string Name { get; set; }

        public List<string> Servers { get; set; }

        public bool Active { get; set; }

        public string Frequency { get; set; }

        public int Timespan { get; set; }

        public TimeSpan TimeOffset { get; set; }

        public DateTime NextRunTime { get; set; }

        public List<TimedCommandItem> Commands { get; set; }
    }
}

