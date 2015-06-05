
namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class GSMTest
    {
        public void PrintInfo()
        {

            GSM nokia = new GSM("3310", "Nokia", 5m, "gosho", new Display(1f, 2), new Battery("E500"));
            GSM motorola = new GSM("e20", "Motorola", 55m, "pesho", new Display(12f, 60), new Battery("G500"));
            GSM siemens = new GSM("M55", "Siemens", 555m, "stamat", new Display(14f, 604), new Battery("H500"));

            GSM[] arrayOfGsmsForTest = {
            nokia,
            motorola,
            siemens
            };

            Console.WriteLine(nokia);
            Console.WriteLine(new string('-',25));
            Console.WriteLine(motorola);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine(siemens);
            Console.WriteLine(new string('-', 25));
            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine(new string('-', 25));
        }
    }
}