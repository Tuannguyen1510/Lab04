using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._4_P2
{
    abstract class Employee : Person
    {
        private string dateHire;
        private double salary;
        private string department;

        protected Employee(string name, int phone, string email,string department, string dateHire, double salary):base(name, phone,email)
        {
            this.Department = department;
            this.DateHire = dateHire;
            this.Salary = salary;
        }

        public string Department { get => department; set => department = value; }
        public string DateHire { get => dateHire; set => dateHire = value; }
        public double Salary { get => salary; set => salary = value; }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Date Hire:");
            DateHire = Console.ReadLine();
            Console.WriteLine("Salary:");
            Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Department:");
            Department = Console.ReadLine();
        }
        public override void ToString()
        {
            base.ToString();
            Console.WriteLine("Department:{0}, DateHire:{1}, Salary:{2}", Department, DateHire, Salary);
        }
        public abstract void Calculate();
        public abstract void CalculateVaction();
        

    }


    class Faculty : Employee
    {
        private int officeHour;
        private string rankl;

        public int OfficeHour { get => officeHour; set => officeHour = value; }
        public string Rankl { get => rankl; set => rankl = value; }
        
        
        protected Faculty(string name, int phone, string email, string department, string dateHire, double salary, int officeHour, string rankl) : base(name, phone, email, department, dateHire, salary)
        {
            this.OfficeHour = officeHour;
            this.Rankl = rankl;
        }

        public override void Calculate()
        {
            Console.WriteLine("Luong: " + (1000 + 0.05 * Salary));
        }

        public override void CalculateVaction()
        {
            if(officeHour >= 3 && Rankl=="GiangVienCaoCap")
            {
                Console.WriteLine("Luong 5 tuan");
            }
            else
            {
                Console.WriteLine("Luong 4 tuan");
            }
        }
        public override void Input()
        {
            base.Input();
        }
    }
    class Staff : Employee
    {
        private string titel;



        protected Staff(string name, int phone, string email, string department, string dateHire, double salary, string titel) : base(name, phone, email, department, dateHire, salary)
        {
            this.Titel = titel;
        }

        public string Titel { get => titel; set => titel = value; }

        public override void Calculate()
        {
            Console.WriteLine("Luong: " + (0.05 * Salary));
        }

        public override void CalculateVaction()
        {
            if (DateHire=="4")
            {
                Console.WriteLine("Luong 5 tuan");
            }
            else
            {
                Console.WriteLine("Luong 4 tuan");
            }
        }
        public override void Input()
        {
            base.Input();
        }
    }

}
