using System.Diagnostics;
using System.Net;
using System.Runtime.Intrinsics.X86;
using AllClass;
namespace OOP328
{


    //Задание 1. Создать программу для авторизации пользователя.Создать класс authorization.Создать поля: имя и пароль.
    //Уровень доступа переменной пароля и переменной повторного пароля, должны быть определены модификатором 
    //private и содержать свойства записи и чтения.В методе нужно создать экземпляр user1.
    //Требуется ввести имя пользователя, затем ввести пароль, и далее ввести пароль повторно.Если пароль совпадает, то вывести сообщение,
    //"Добро пожаловать!". Если пароль не совпадает, то вывести сообщение, "Введите пароль заново!". Ввод пароля осуществляется до тех пор, 
    //пока не будет введен верный пароль.



    internal class Program
    {
        static void Main(string[] args)
        {

            AllClass.Authorization authorization = new AllClass.Authorization();

            authorization.setMethod();


        }  
    }
}
