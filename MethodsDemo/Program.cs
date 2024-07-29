namespace MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //MethodOverloadingDemo demo = new MethodOverloadingDemo();
             //Console.WriteLine(demo.Add(1, 2));
             //Console.WriteLine(demo.Add("aa", "bb"));

            NamedPara namedPara = new NamedPara();


            namedPara.DisplayDetails(909, "accts", "deepak", 9, 90000.9f);
            
            // named parameter
            namedPara.DisplayDetails(empId: 909, dept: "accts", name: "ranjeet",
                exp: 9, salary: 90909.6f);

            namedPara.DisplayDetails(exp: 9, salary: 909.6f,
                name: "ajay", dept: "accts", empId: 10);

            DefaultPara defaultPara = new DefaultPara();
            defaultPara.SI(12000, 9, 10);
            defaultPara.SI(12000, 9);
            defaultPara.SI(20000);
            defaultPara.SI();
            OutputParaDemo outputParaDemo = new OutputParaDemo();
            int add, difference, prouct;
            float rem;
            // calling part where output para are involved
            outputParaDemo.Operations(20, 10,
                out add, out difference, out prouct,
                out rem);
            Console.WriteLine($"Sum is {add}");
            Console.WriteLine($"Difference is {difference}");
            Console.WriteLine($"Product is {prouct}");
            Console.WriteLine($"Remiander is {rem}");


            // call by value
            int x = 10;
            Console.WriteLine($"Value of x in Main before calling Change1 is {x}");
            CallByValueCallByRef callByValueCallByRef = new CallByValueCallByRef();
            callByValueCallByRef.Change1(x);
            Console.WriteLine($"Value of x in Main after calling Change1 is {x}");
            callByValueCallByRef.Change2(ref x);
            Console.WriteLine($"Value of x in Main after calling Change2 is {x}");
            ParamsArrayDemo ParamsArrayDemo = new ParamsArrayDemo();
            Console.WriteLine("Sum is " + ParamsArrayDemo.Add(1, 1, 3));
            Console.WriteLine("Sum is " + ParamsArrayDemo.Add(1, 2, 3, 4, 5, 6, 6, 7, 7, 7, 7, 7, 7, 7));
            Console.WriteLine("Sum is " + ParamsArrayDemo.Add(1)); 













        }
    }
}
