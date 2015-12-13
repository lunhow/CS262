using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public static int TotalMembers { get; set; }

        private static int totalMembers = 0;

        public Employee(string name)
        {
            this.Name = name;
            Employee.TotalMembers++;
        }

        public Employee(Employee employee)
        {
            this.Name = employee.Name;
            this.Phone = employee.Phone;
        }

        public Employee Clone()
        {
            return new Employee(this);
        }

        public override string ToString()
        {
            string result = string.Empty;
            result = string.Format("Employee Name {0}, Phone {1}", this.Name, this.Phone == string.Empty ? "資料尚未建立" : this.Phone);
            return result;
        }

        public static void ResetTotalMembers()
        {
            Employee.TotalMembers = 0;
        }
    }
}