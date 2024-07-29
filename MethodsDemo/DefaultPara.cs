using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class DefaultPara
    {
        // def / optional para are used to set some def value
        public void SI(int principal=20000, int time=10, int rate=7)
        {
            Console.WriteLine((principal*rate*time)/100);
        }
    }
}
