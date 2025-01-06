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

            Student Bob = new Student("Bob");
            Group Sam = new Group("Sam", "333");


            Console.Write("Введите имя для поиска: ");
            string inputName = Console.ReadLine();
     
            if (inputName == Sam.Name)
            {
                Sam.GetOutput();
            }else{
                Console.WriteLine("В группе №333 такого имени не существует");
            }

        }
    }




}
