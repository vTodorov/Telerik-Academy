
namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSM
    {

        public string Model { get; private set; }
        public string Manufacturer { get; private set; }
        private decimal price;
        public string ownerName { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        private static GSM iPhone4S = new GSM("IPhone 4S", "Apple", 1200, "Owner Name Here", new Display(5f, 256), new Battery("4s Battery", 350, 35, BatteryTypeEnum.Li_Ion));

        public decimal Price 
        {
            get 
            {
              return  this.price;
            }
            set
            {
                if (value<0)
                {
                    throw new FormatException("Price have to be positive decimal");
                }

                this.price = value;
            
            }
        }

        public static GSM IPhone4S
        {
            get { return iPhone4S; }
        }

        public GSM(string phoneModel, string phoneManufacturer)
        {
            this.Model = phoneModel;
            this.Manufacturer = phoneManufacturer;
            this.Battery = new Battery("", 0, 0, BatteryTypeEnum.Li_Ion);
            this.Display = new Display(0, 0);
            this.CallHistory = new List<Call>();

        }
        public GSM(string phoneModel, string phoneManufacturer, decimal phonePrice)
            : this(phoneModel, phoneManufacturer)
        {
            this.Price = phonePrice;
        }
        public GSM(string phoneModel, string phoneManufacturer, decimal phonePrice, string owner, Display display, Battery batery)
            : this(phoneModel, phoneManufacturer, phonePrice)
        {
            this.ownerName = owner;
            this.Display = display;
            this.Battery = batery;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Model: ");
            result.AppendLine(this.Model);
            result.Append("Manufacturer: ");
            result.AppendLine(this.Manufacturer);
            result.Append("Price: ");
            result.AppendLine(this.Price.ToString());
            result.Append("Owner Name: ");
            result.AppendLine(this.ownerName);
          //  result.AppendLine();
            result.AppendLine("     Battery info: ");
            result.Append("Battery model: ");
            result.AppendLine(this.Battery.BatteryModel);
            result.Append("Battery hours idle: ");
            result.AppendLine(this.Battery.HourIdle.ToString());
            result.Append("Battery hours talk: ");
            result.AppendLine(this.Battery.HourTalk.ToString());
            result.Append("Battery type: ");
            result.AppendLine(this.Battery.BatteryType.ToString());
       //     result.AppendLine();
            result.AppendLine("     Display info: ");
            result.Append("Display size: ");
            result.AppendLine(this.Display.Size.ToString());
            result.Append("Number of colors: ");
            result.AppendLine(this.Display.NumberOfColors.ToString());

            return result.ToString();
        }

        public List<Call> CallHistory { get; set; }


        public void RemoveCall(Call call)
        {
            CallHistory.Remove(call);
        }
        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }
        public void ClearCalls()
        {

            CallHistory.RemoveRange(0, CallHistory.Count);

        }
        public decimal TottalPriceOfCallsInHistory(decimal costOfMinute)
        {
            decimal tottalPrice = 0;

            for (int i = 0; i < CallHistory.Count; i++)
            {
                decimal currentPrice = ((decimal)CallHistory[i].DurationOfCall/60) * costOfMinute;
                tottalPrice += currentPrice;
                
            }

            return tottalPrice;
        }

        public string CallHistoryInfo()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                builder.Append("Call date: ");
                builder.AppendLine(this.CallHistory[i].CallDateTime.ToString());
                builder.Append("number: ");
                builder.AppendLine(this.CallHistory[i].PhoneNumber.ToString());
                builder.Append("duration: ");
                builder.AppendLine(this.CallHistory[i].DurationOfCall.ToString());

            };
            return builder.ToString();
        }

    }
}
