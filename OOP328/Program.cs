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

            Student Ivan = new Student("Ivan Ivanovich Ivanov", "pup");

            Ivan.GetInfo();

            Teacher Marina = new Teacher("Marina Marina Marina", "Math");

            Marina.GetInfo();

            MyObject1<int> myObject1 = new MyObject1<int>(231);

            MyObject3<string, int, double> myObject3 = new MyObject3<string, int, double>("Bob", 23, 33.21);

            myObject1.GetInfo();

            myObject3.GetInfo();

        }
    }




}
