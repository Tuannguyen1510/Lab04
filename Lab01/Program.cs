using Lab01;

internal class Program
{
     static void Main(string[] args)
    {
        /*
        // khởi tạo đối tượng Student 
        Student student = new Student();
        student.Display();
        // Gán 
        Console.WriteLine("Nhập Id:");
        student.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập Name:");
        student.Name= Console.ReadLine();

        Console.WriteLine("Nhập Age:");
        student.Age = int.Parse(Console.ReadLine());


        student.Display();
        // khởi tạo contructor có tham số 
        student = new Student(111, "A", 44);
        student.Display();

        

        NapChong napChong = new NapChong();
        int sum = napChong.Sum(10);
        Console.WriteLine(sum);


        int sum1 = napChong.Sum(10,20);
        Console.WriteLine(sum1);


        int add = napChong.Add(10, 20);
        Console.WriteLine(add);

        double add1  = napChong.Add(10.0, 20.0);
        Console.WriteLine(add);
        

        Animal animal = new Animal();
        animal.Eat();
        animal.DoSomeThing();
        //
        Cat cat = new Cat();
        cat.Eat();
        cat.DoSomeThing();
        cat.Action();
        cat.Display();
        */

        Dog dog = new Dog();
        dog.DogAction();
    }
}