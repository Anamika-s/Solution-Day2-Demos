using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class NamedPara
    {
        public void DisplayDetails(int empId,
            string name, string dept, int exp,
            float salary)
        {
            Console.WriteLine($"Details are\n\nID is {empId}\nName is {name}\nDept is {dept}\n" +
                $"Exp is {exp}\nSalaryt is {salary} ");
        }
    }
}
