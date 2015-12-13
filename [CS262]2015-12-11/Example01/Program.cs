using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee anEmployee = new Employee("Harry");
            Console.WriteLine(anEmployee.Name);
            Employee anEmployee2 = anEmployee.Clone();
            Console.WriteLine(anEmployee2.Name);
            anEmployee2.Name = "Harry分身";
            Console.WriteLine("本尊是{0} 分身是{1}", anEmployee.Name, anEmployee2.Name);
            Console.WriteLine("");
        }
    }
}