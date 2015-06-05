using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayHello
{
    class Hello
    {
        static void Main(string[] args)
        {
            Name();
        }
        static void Name()
        {
            string name;
            Console.Write("What's your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, {0} !", name);
        }
    }
}
