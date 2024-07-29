using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // collections
           // are structures which allows to store multiple elements
           // collections are dynamic in nature, memory is not wasted
           // collection is a term, but we use classes
           // collections have inbuilt methods to perform simple functions
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Insert(1, 100);
            Console.WriteLine("after inserting 100 at 1 pos" );
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            list.RemoveAt(0);

            list.Remove(2);
            Console.WriteLine("after deleting");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }


            // insertion & deletion happens only in 1 pos
            // Stack LIFO
              Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            Console.WriteLine("stack ");
            foreach(int i in stack)
                Console.WriteLine(i);

            stack.Pop();
            Console.WriteLine("stack after deletion ");
            foreach (int i in stack)
                Console.WriteLine(i);

            // FIFO effect
            Queue queue = new Queue();
            queue.Enqueue(1000);
            queue.Enqueue(2000);
            queue.Enqueue(3000);

            Console.WriteLine("queue ");
            foreach (int i in queue)
                Console.WriteLine(i);

            queue.Dequeue();

            Console.WriteLine("queue after deletion");
            foreach (int i in queue)
                Console.WriteLine(i);

            // how can we search elements
            // only thru iteration
            // sequential searching
         //foreach (int i in queue)
            
            if(queue.Contains(2000))
                    Console.WriteLine("found");


            // Hashtable which stores data ib key,value pair

            // used to dynamically search value
            Hashtable ht = new Hashtable();
            ht[100] = "ajay";
            ht[101] = "deepak";
            ht[102] = "kavi";

            Console.WriteLine(ht[102]);

            foreach (int key in ht.Keys)
                Console.WriteLine($"Name of rn {key} is {ht[key]}");

















        }
    }
}
