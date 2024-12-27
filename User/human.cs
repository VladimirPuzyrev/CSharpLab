using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class Human
    {
        private string name;
        private int age;

        public Human(string name, int age) 
        {
            this.name = name;
            this.age = age;
        }

        public void getInfo()
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}", name, age);
        }
    }
}
