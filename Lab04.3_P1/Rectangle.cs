using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._3_P1
{
    public  class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public void InputData()
        {
            Console.WriteLine("Nhap chu dai:");
            Height = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chu rong:");
            Width = Double.Parse(Console.ReadLine());
        }
        public override double Area()
        {
            return Height * Width;
        }
        public override double Cirumference()
        {
            return 2 * Height * Width;
        }
    }
}
