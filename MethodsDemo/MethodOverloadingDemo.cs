using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class MethodOverloadingDemo
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        //public float Add(int x, int y, int z)
        //{
        //    return x + y + z;
        //}
        public float Add(int x, float y)
        {
            return x + y;
        }
        public float Add(float x, int y)
        {
            return x + y;
        }

        public string Add(string x, string y)
        {
            return string.Concat(x, " " ,y);
        }













    }
}
