using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class OutputParaDemo
    {
        // a function can return only 1 value
        // but if you want that a function shud return more than 1 
        // value, we can use output para
        public void Operations(int x, int y,
           out int sum, 
           out int difference,
           out int product,
           out float remainder)

        {
            sum = x + y; 
            difference = x- y; 
            product = x * y;
            remainder = x % y;
            
        }

    }
}
