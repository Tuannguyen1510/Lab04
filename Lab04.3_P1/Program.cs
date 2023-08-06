
using Lab04._3_P1;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.InputData();

        Console.WriteLine("Chu vi:" + circle.Cirumference());
       
        Console.WriteLine("Dien tich:" + circle.Area());


        //
        Lab04._3_P1.Rectangle rectangle = new Lab04._3_P1.Rectangle();
        rectangle.InputData();
        Console.WriteLine("Chu vi:" + rectangle.Cirumference());

        Console.WriteLine("Dien tich:" + rectangle.Area());

    }
}