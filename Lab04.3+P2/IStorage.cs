using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._3_P2
{
   public interface IStorage
    {
        string  Data { get; }

        public void Read(object filename);
        public void Write(object filename);
    }
    public interface IEncrytable {
        public void Encrypt();
        public void Decrypt();
        void Read(object filename);
    }

    class Document : IStorage, IEncrytable
    {
        public string data = "A";

        public string Data
        {
            get
            {
                return data;
            }
        }

        public void Decrypt()
        {
            Console.WriteLine("Ma hoa");
        }

        public void Encrypt()
        {
            Console.WriteLine("Giai Ma");
        }

       

        public  void Read(object filename)
        {
            Console.WriteLine("Doc: " + data);
        }

      

        public  void Write(object filename)
        {
            Console.WriteLine("Viet: " + data);
        }
    }


}
