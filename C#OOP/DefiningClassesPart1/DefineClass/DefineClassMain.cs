namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class DefineClassMain
    {
        static void Main()
        {
            GSMTest gencho = new GSMTest();
            gencho.PrintInfo();
            GSMCallHistoryTest pesho = new GSMCallHistoryTest();
            pesho.CallTest();
        }
    }
}
