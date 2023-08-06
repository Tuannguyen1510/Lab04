using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._4_P1
{
    class  Staff: IPerson
    {
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
            Console.WriteLine("Đối tượnghiển thị: " + obj);

        }
    }
}
