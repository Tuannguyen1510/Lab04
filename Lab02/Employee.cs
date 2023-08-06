using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Employee
    {
        int id = 10;
        string name = "Tran Thu Ha";
        int age = 20;

        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public virtual int AgeYear()
        {
            return age;
        }

        protected void Display()
        {
            Console.WriteLine("Emp Id: " + id);
            Console.WriteLine("Emp Name: " + name);
            Console.WriteLine("Emp Age: " + age);
        }

    }

    class Department : Employee {
        int depid = 20;
        string depname = "Information technology";

        public Department(int id, string name, int age, int depid, string depname) : base(id, name, age)
        {
            this.depid = depid;
            this.depname = depname;
        }

        public override int AgeYear()
        {
            return AgeYear() + 10;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Dep Id: " + depid);
            Console.WriteLine("Dep Name: " + depname);
        }
    }

}
