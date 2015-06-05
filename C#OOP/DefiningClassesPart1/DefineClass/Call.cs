namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Call
    {
        private DateTime callDateTime;
        private string phoneNumber;
        private int durationOfCall;

        public DateTime CallDateTime
        {
            get
            {
                return this.callDateTime;
            }
           
        }
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set 
            {
                if (value.Length<10)
                {
                    throw new FormatException("Invalid Number");
                }
                this.phoneNumber = value;
            }
        }
        public double DurationOfCall
        {
            get
            {
                return this.durationOfCall;
            }
           private set 
            {
                if (value<0)
                {
                    throw new FormatException("durationOfCall have to be positive number");
                }
                this.durationOfCall = (int)value;
            }
        }

        public Call(DateTime callDateTime, string phoneNumber, int durationOfCall)
        {
            this.callDateTime = callDateTime;
            this.phoneNumber = phoneNumber;
            this.durationOfCall = durationOfCall;
        }
        

    }
}
