
namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Battery
    {
        public string BatteryModel { get; private set; }
        private double hourIdle;
        private double hoursTalk;

        public double HourIdle
        {
            get { return this.hourIdle; }


           private set
            {
                if (value < 0)
                {
                    throw new FormatException("HourIdle have to be positive number!");
                }

                this.hourIdle = value;
            }

        }
        public double HourTalk 
        {
            get { return this.hoursTalk; }


            set
            {
                if (value < 0)
                {
                    throw new FormatException("HoursTalk have to be positive number!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryTypeEnum BatteryType { get; set; }

        public Battery(string batteryModel)
        {
            this.BatteryModel = batteryModel;
            this.HourIdle = 0;
            this.HourTalk = 0;
            this.BatteryType = 0;
        }

        public Battery(string batteryModel, double hourIdle, double hourTalk, BatteryTypeEnum batteryType)
            : this(batteryModel)
        {
            this.HourIdle = hourIdle;
            this.HourTalk = hourTalk;
            this.BatteryType = batteryType;
        }
    }
}
