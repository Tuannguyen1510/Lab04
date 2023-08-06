using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._4_P2
{
    internal class Person
    {
        private string name;
        private int phone;
        private string email;

        public string Name { get => name; set => name = value; }
        public int Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }

        public Person(string name, int phone, string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }
        public virtual void Input()
        {
            Console.WriteLine("Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Phone:");
            Phone = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Email:");
            Email = Console.ReadLine();
        }
        public virtual void ToString() {
            Console.WriteLine("Name:{0}, Phone:{1}, Email:{2}", Name, Phone, Email);
        }

    }
}
