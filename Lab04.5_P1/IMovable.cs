using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._5_P1
{
    public interface IMovable: IDrivable,ISteerable
    {
        public void Accelerate();
        public void Brake();

    }

   public class Car : IMovable
    {
        public bool started = false;
        public bool Started {
            get
            {
                return started;
            }
        }


        public void Accelerate()
        {
            started = true;
        }

        public void Brake()
        {
            Console.WriteLine("Brake:"); 
        }

        public void Start()
        {
            Console.WriteLine("Start:");
            started = true;
        }

        public void Stop()
        {
            Console.WriteLine("Stop:");
            started = false;
        }

        public void TurnLeft()
        {
            Console.WriteLine("Left:");
        }

        public void TurnRight()
        {
            Console.WriteLine("Left:");
        }
    }
}
