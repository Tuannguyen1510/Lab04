namespace Lab04._3_P1
{
   public abstract class Shape
    {

        public abstract double Area();
        public abstract double Cirumference();

    }
   public class Circle : Shape {
        public double Radius { get; set; }

        public void InputData()
        {
            Console.WriteLine("Nhap ban kinh:");
            Radius = Double.Parse(Console.ReadLine());
        }
        public override double Area()
        {
            return 3.14F * Radius * Radius;
        }
        public override double Cirumference()
        {
            return 2* 3.14F * Radius;
        }
    }
}
