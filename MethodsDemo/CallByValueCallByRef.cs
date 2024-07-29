using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class CallByValueCallByRef
    {
        public void Change1(int x)
        {
            x = 2000;
            Console.WriteLine($"Value of x in Change1 is {x}");
        }

        public void Change2(ref int x)
        {
            x = 3000;
            Console.WriteLine($"Value of x in Change2 is {x}");
        }
    }
}
