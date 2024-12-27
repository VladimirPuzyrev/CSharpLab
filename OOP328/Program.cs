using System.Diagnostics;
using User;
namespace OOP328
{


    //Задание 1. Создать класс human.
    //В основном методе класса human, создать экземпляр класса и создать инициализацию объекта класса, присвоив полю name значение "Bob", а к полю age, значение 19.
    //Для класса human создать библиотеку классов user, в библиотеке классов указать два поля строкового типа данных, name и age. 



    internal class Program
    {
        static void Main(string[] args)
        {
           Human human = new Human("Bob", 19);

           human.getInfo();
        }  
    }
}
