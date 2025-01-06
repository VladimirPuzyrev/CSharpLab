using System.Diagnostics;
using System.Net;
using System.Runtime.Intrinsics.X86;
using AllClass;

namespace OOP328
{



        

    internal class Program
    {
        static void Main(string[] args)
        {

            //R r = new R();

            Clock clock = new Clock();
            int val = 34;
            clock.Hours = val % 24;
            val = clock.Hours;

            Console.WriteLine(val);

        }
    }




}
