using System.Diagnostics;
using AllClass;
namespace OOP328
{


    //Задание 1. Разработать перегрузку методов нахождения суммы 2, 3, 4 чисел.

    //Задание 2. Разработать программу, в которой нужно ввести ФИО студента и его группу.Требуется сделать проверку по группе. 
    //Если введенная группа не совпадает с группой ПО-328, то вывести сообщение "Группа не совпадает", а если совпадает, то вывести сообщение 
    //"Группа совпадает"



    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            GroupCheck groupCheck = new GroupCheck();

            calculator.Sum(1, 2);
            calculator.Sum(1, 2, 3);
            calculator.Sum(1, 2, 3, 4);


            Console.WriteLine();

            groupCheck.Name = "Пузырев";
            groupCheck.Group = "ПО-328";

            Console.WriteLine(groupCheck.Name);
            Console.WriteLine(groupCheck.Group);
            
            groupCheck.Group = "nigga";

            Console.WriteLine(groupCheck.Group);
        }  
    }
}
