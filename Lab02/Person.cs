using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Person
    {
        string id, name, address, phone;

        public Person(string id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }
    }
    class Staff : Person {
        int salary;

        public Staff(string id, string name, string address, string phone, int salary) : base(id, name, address, phone)
        {
            this.salary = salary;
        }
    }

}
