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

            State state1 = new State(50000, 123);
            State state2 = new State(30000, 0000);

            State state3 = state1 + state2;
            bool isGreater = state1 > state2;

            state3.GetState();

            Console.WriteLine(isGreater);
        }
    }




}
