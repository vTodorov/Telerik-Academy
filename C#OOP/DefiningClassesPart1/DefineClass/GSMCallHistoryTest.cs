
namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

   public class GSMCallHistoryTest
    {
       private const decimal PRICE_PER_MINUTE = 0.38m;
       public void CallTest()
       {
           GSM pesho = new GSM("bla lba", "dryn dtyn");
           Call firstCall = new Call(DateTime.Now, "0888888888", 5000);
           Call secondCall = new Call(DateTime.Now.AddHours(1), "0777777777", 1000);
           Call thirdCall = new Call(DateTime.Now.AddHours(2), "0999999999", 3000);
           pesho.AddCall(firstCall);
           pesho.AddCall(secondCall);
           pesho.AddCall(thirdCall);

           Console.WriteLine(pesho.CallHistoryInfo());

           Console.WriteLine("Tottal price: {0:F3}",pesho.TottalPriceOfCallsInHistory(PRICE_PER_MINUTE));

           int longestCall = 0;
           Call longestCallDuration=new Call(DateTime.Now,"0",0);
           for (int i = 0; i < pesho.CallHistory.Count; i++)
           {
               if (pesho.CallHistory[i].DurationOfCall>longestCall)
               {
                   longestCall = (int)pesho.CallHistory[i].DurationOfCall;
                   longestCallDuration = pesho.CallHistory[i];
               }
           }
           pesho.RemoveCall(longestCallDuration);

           pesho.TottalPriceOfCallsInHistory(PRICE_PER_MINUTE);

           pesho.ClearCalls();

           Console.WriteLine(pesho.CallHistoryInfo());

       }
    }
}
