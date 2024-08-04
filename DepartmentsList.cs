using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class DepartmentsList
    {
        Department[] Departments;
        int CountDepartments;

        public DepartmentsList()
        {
            Departments = new Department[20];
            CountDepartments = 0;
        }

        public int GetCountOfDepartments()
        {
            return CountDepartments;
        }

        public void AddNewDepartment(int id, string name)
        {
            Departments[CountDepartments] = new Department();

            Departments[CountDepartments].ID = id;
            Departments[CountDepartments].DepartmentName = name;

            CountDepartments++;
        }

        public void PrintAllDepartments()
        {
            for(int i = 0; i < CountDepartments; ++i)
            {
                Console.WriteLine($"--- Department {i + 1} ---");
                Departments[i].PrintDepartmentInfo();
                Console.WriteLine("-----------");
            }
        }

        public int[] GetIdsDepartments()
        {
            int[] Arr = new int[CountDepartments];

            for(int i = 0; i < CountDepartments; ++i)
            {
                Arr[i] = Departments[i].ID;
            }

            return Arr;
        }
    }
}
