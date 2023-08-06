using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04._5_P1
{
   public interface IDrivable
    {
        public void Start();
        public void Stop();

        public bool Started { get; }
  
    }
}
