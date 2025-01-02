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


            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["red"]);

            dictionary.PrintAll();


            Group PO32 = new Group();

            PO32[1] = new Student { Name = "BOB", Age = 18 };

            Library library = new Library();

            library[0] = new Book { Title = "1984", Author = "Man" };


            //PhoneBook phoneBook = new PhoneBook();

            //phoneBook["Alice"] = "+123456789";
            //phoneBook["Bob"] = "+987654321";

            //Console.WriteLine(phoneBook["Alice"]); // +123456789
            //Console.WriteLine(phoneBook["Charlie"]); // Контакт не найден
        }
    }




}
