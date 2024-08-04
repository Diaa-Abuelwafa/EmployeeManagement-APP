using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class Project
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public double CurrentCost { get; set; }
        public int ManagerID { get; set; }

        Budget[] Budgets;

        int CountBudgets;
        public Project()
        {
            Budgets = new Budget[20];
            CountBudgets = 0;
        }

        public double CalculateBudgets()
        {
            // To Calculate Amount Of All Budgets At The Project
            return 0.0;
        }

        public void Print()
        {
            Console.WriteLine($"The ID Of This Project : {this.ID}");
            Console.WriteLine($"The Location Of This Project : {this.Location}");
            Console.WriteLine($"The Currunt Cost Of This Project : {this.CurrentCost}");
            Console.WriteLine($"The Currunt Cost Of This Project : {this.CurrentCost}");

            Staff StaffTemp = new Staff();
            StaffTemp.PrintMemberWithId(ManagerID);

            for(int i = 0; i < CountBudgets; ++i)
            {
                Console.WriteLine($"---- Budet {i + 1} ----");
                Console.WriteLine($"The ID Of This Budget Is {Budgets[i].ID}");
                Console.WriteLine($"The Value Of This Budget Is {Budgets[i].Value}");
                Console.WriteLine("------------------------");
            }
        }

        public void SetBudgets(Budget[] Bs)
        {
            CountBudgets = 0;

            for(int i = 0; i < Bs.Length; ++i)
            {
                // Must Create An Object Of 'Budget'
                this.Budgets[i] = new Budget();

                this.Budgets[i].ID = Bs[i].ID;
                this.Budgets[i].Value = Bs[i].Value;

                CountBudgets++;
            }
        }

        public void AddBudget(int id, double value)
        {
            int Length = CountBudgets;

            Budget[] NewBudets = new Budget[Length + 1];
            
            for(int i = 0; i < Length; ++i)
            {
                NewBudets[i] = new Budget();

                NewBudets[i].ID = Budgets[i].ID;
                NewBudets[i].Value = Budgets[i].Value;
            }

            NewBudets[Length] = new Budget();

            NewBudets[Length].ID = id;
            NewBudets[Length].Value = value;

            this.SetBudgets(NewBudets);
        }

        public void IncreaseBudget(int id, double addsvalue)
        {
            for(int i = 0; i < CountBudgets; ++i)
            {
                if (Budgets[i].ID == id)
                {
                    Budgets[i].IncreaseBudget(addsvalue);
                }
            }
        }

        public int[] GetBudgetsIds()
        {
            int[] Arr = new int[CountBudgets];

            for(int i = 0; i < CountBudgets; ++i)
            {
                Arr[i] = Budgets[i].ID;
            }

            return Arr;
        }
    }
}
