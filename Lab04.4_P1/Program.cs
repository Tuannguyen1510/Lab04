using Lab04._4_P1;

internal class Program
{
    private static void Main(string[] args)
    {
        // tạo đối tượng
        IPerson staff = new Staff();
        object data = "AAA";
        staff.InSert(data);
        staff.Delete(data);
        staff.Update(data);
        staff.Display(data);
        // tạo sinh viên 
        IPerson student = new Student() { Id = 1, Name = "S10", Age = 12 };
        student.Display(student);
    }
}