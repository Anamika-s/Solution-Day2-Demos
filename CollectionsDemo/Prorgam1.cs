using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class Prorgam1
    {
        static void Main()
        {
            // generic collections are type safe
            // ArrayList > System.Collections
            // List<Type> > System.Collections.Generic
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            foreach(int i in list)
                Console.WriteLine(i);

            Stack<string> strings = new Stack<string>();
            strings.Push("a");
            strings.Push("b");


            Queue<float> queue = new Queue<float>();
            queue.Enqueue(1.0f);
            queue .Enqueue(1.1f);

            Dictionary<int, string> names = new Dictionary<int, string>();
            names[100] = "ajay";

















        }
    }
}
