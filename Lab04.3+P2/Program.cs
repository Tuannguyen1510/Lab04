using Lab04._3_P2;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {

        IStorage storage = new Lab04._3_P2.Document();
        Object filename = "BBB";
        storage.Write(filename);
        storage.Read(filename);

        Lab04._3_P2.Document d  = new Lab04._3_P2.Document();
        d.Read(filename);
        d.Write(filename);
    }
}