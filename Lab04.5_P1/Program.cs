using Lab04._5_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();
        car.Start();
        car.TurnLeft();
        car.TurnRight();
        car.Accelerate();
    }
}