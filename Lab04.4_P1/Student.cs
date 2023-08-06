using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._4_P1
{
    class Student: IPerson
    {
   
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void InSert(Object obj)
        {
            Console.WriteLine("Đối tượng thêm: " + obj);
        }
        public void Delete(Object obj)
        {
            Console.WriteLine("Đối tượng xóa: " + obj);

        }
        public void Update(Object obj)
        {
            Console.WriteLine("Đối tượng cập nhật: " + obj);

        }
        public void Display(Object obj)
        {
            Student student = (Student)obj;
            Console.WriteLine("Đối tượng hiển thị:{0}, {1},{2} " ,student.Id,student.Name,student.Age);

        }
    }
}
