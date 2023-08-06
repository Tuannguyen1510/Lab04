using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Lab04._2_P1
{
    abstract class Student
    {
        private string name;
        private int year;

        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }

        public void Display()
        {
            Console.WriteLine("Student name:{0}, year:{1}", Name, Year);
        }

        public abstract double Average();
      
    }


    class StudentCollege : Student
    {
        protected double score1, score2,score3;

        public StudentCollege(string name, int year,double score1, double score2,double score3) : base(name, year)
        {
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        public override double Average()
        {
            return (score1+score2+score3) / 3;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Student name:{0}, year:{1}, av:{2}", Name, Year, Average());
        }
    }

    class StudentUniversity : StudentCollege {
        protected double score4;
        public StudentUniversity(string name, int year, double score1, double score2, double score3,double score4) : base(name, year, score1, score2, score3)
        {
            this.score4 = score4;
        }
        public override double Average()
        {
            return (score1 + score2 + score3 +score4) / 4;
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Student name:{0}, year:{1}, av:{2}", Name, Year, Average());
        }
    }


}
