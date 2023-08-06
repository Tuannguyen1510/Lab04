using Lab04._2_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        StudentCollege sv1 = new StudentCollege("H", 2000, 10, 8, 7);
        sv1.Display();
        Console.WriteLine("DTB:" + sv1.Average());
        Console.WriteLine("--------display----------");
        StudentUniversity sv2 = new StudentUniversity("Hii", 2000, 10, 8, 7,6);
        sv2.Display();
        Console.WriteLine("DTB:" + sv2.Average());
    }
}