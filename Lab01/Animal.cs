using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Animal
    {
        // protected 
        protected string Food { get; set; }
        protected string Name { get; set; }

        // method 
        public void Eat()
        {
            Console.WriteLine("Động vật ăn 1 vài thứ");

        }
        public void DoSomeThing()
        {
            Console.WriteLine("Động vật làm một vài thứ");
        }
    }
    class Cat : Animal { 
       public void Action()
        {
            Eat();
            DoSomeThing();
        }
        public void Display()
        {
            Food = "";
            Name = "ADFGH";
            Console.WriteLine("Food:" + Food);
            Console.WriteLine("Name:" + Name);
        }

    }


    class Dog : Animal { 
        public void Eat()
        {
            Console.WriteLine("Dog eating");

        }
        public void DogAction()
        {
            Dog dog = new Dog();
            dog.Eat();

            // sử dụng lớp cha
            base.Eat();
        }
    }


}
