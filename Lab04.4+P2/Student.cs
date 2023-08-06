using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._4_P2
{
    internal class Student : Person
    {
        private string enrolled;

        public Student(string name, int phone, string email, string enrolled) : base(name, phone, email)
        {
            this.Enrolled = enrolled;
        }

        public string Enrolled { get => enrolled; set => enrolled = value; }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine("Enrolled: " + Enrolled);
        }
    }
}
