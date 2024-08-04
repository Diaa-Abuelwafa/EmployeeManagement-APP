using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }

        public void PrintDepartmentInfo()
        {
            Console.WriteLine($"The ID Of This Department Is {this.ID}");
            Console.WriteLine($"The Name Of This Department Is {this.DepartmentName}");
        }
    }
}
