using System.Diagnostics;

namespace OOP328
{


    //Задание 1. Создать структуру студента.Задать 3 поля: ФИО, дата рождения, группа. Создать один экземпляр структуры.
    //Организовать конструктор для инициализации полей структуры.Выполнить вывод всех полей через метод GetInfo.

    //Задание 2. Создать класс Tiles (кафель), который будет содержать поля с открытым доступом: brand, size_h, size_w, price и метод класса getData(). 
    //В главной функции объявить пару объектов класса и внести данные в поля. Затем отобразить их, вызвав метод getData().

    struct Student()
    { 
        private string fullName;
        private int age;
        private string group;


        public Student(string fullName, int age, string group) : this()
        {
            this.fullName = fullName;
            this.age = age;
            this.group = group;
        }


        public void getInfo()
        {
            Console.WriteLine("ФИО: {0}\nВозраст: {1}\nВозраст: {2}", fullName, age, group);
        }

    }

    class Tiles()
    {
        private string brand;
        private int size_h;
        private int size_w;
        private int price;

        public Tiles(string brand, int size_h, int size_w, int price) : this()
        {
            this .brand = brand;
            this .size_h = size_h;
            this .size_w = size_w;
            this .price = price;
        }

        public void getData()
        {
            Console.WriteLine("Бренд: {0}\nВысота: {1}\nШирота: {2}\nЦена: {3}", brand, size_h, size_w, price);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Пузырев Владимир Владимирович", 21, "PO-328");
            student.getInfo();

            Console.WriteLine();

            Tiles tiles = new Tiles("Крутой", 25, 25, 25000);
            tiles.getData();
        }
    }
}
