using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer time = new Timer(12);

            ClassHandler1 a = new ClassHandler1();
            ClassHandler2 b = new ClassHandler2();
            time.onTime += a.Messege;
            time.StartTimer();
        }
    }
}
