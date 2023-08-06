using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Student
    {

        // field / properties 
        // properties dynamic 
        public int Id { get; set; } // field Id
        public string Name { get; set; }    // field Name
        public int Age { get; set; }    // field Age

        // Contructor: mặc định Student(){ this.ID= 0 , this.Name= null , this.Age=0}
        
        
        
        // Contructor không tham số 
        public Student() {
            Id = 0;
            Name = "";
            Age = 0;
        }
        // Contructor có tham số
        public Student(int Id, string Name, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        // Method 
        public void Display()
        {
            Console.WriteLine("---- Thông tin sinh viên---------");
            Console.WriteLine("\tID\t" + Id);
            Console.WriteLine("\tName\t:{0}", Name);
            Console.WriteLine("\tAge\t:{0}", Age);
        }

    }
}
