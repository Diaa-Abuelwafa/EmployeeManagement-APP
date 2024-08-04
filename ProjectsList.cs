using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class ProjectsList
    {
        Project[] Projects;
        int CountProjects;

        public ProjectsList()
        {
            Projects = new Project[20];
            CountProjects = 0;
        }

        public void AddNewProject(int id, string location, double currentcost, int managerid, Budget[] Budgets)
        {
            Projects[CountProjects] = new Project();

            Projects[CountProjects].ID = id;
            Projects[CountProjects].Location = location;
            Projects[CountProjects].CurrentCost = currentcost;
            Projects[CountProjects].ManagerID = managerid;
            Projects[CountProjects].SetBudgets(Budgets);

            CountProjects++;
        }

        public int GetNumbersOfProjects()
        {
            return CountProjects;
        }

        public void PrintAllProjects()
        {
            for(int i = 0; i < CountProjects; ++i)
            {
                Console.WriteLine($"----- Project {i + 1} -----");
                Projects[i].Print();
                Console.WriteLine("-----------------------------");
            }
        }

        public int[] GetProjectsIds()
        {
            int[] Arr = new int[CountProjects];

            for(int i = 0; i < CountProjects; ++i)
            {
                Arr[i] = Projects[i].ID;
            }

            return Arr;
        }

        public void AddBudget(int id1, int id2, double value)
        {
            for(int i = 0; i < CountProjects; ++i)
            {
                if (Projects[i].ID == id1)
                {
                    Projects[i].AddBudget(id2, value);
                    break;
                }
            }
        }

        public void IncreaseBudgetForExistingProject(int id1, int id2, double addsvalue)
        {
            for(int i = 0; i < CountProjects; ++i)
            {
                if (Projects[i].ID == id1)
                {
                    Projects[i].IncreaseBudget(id2, addsvalue);
                }
            }
        }

        public int[] GetBudgetsIdsOfProject(int id)
        {
            int[] Arr = new int[0];

            for (int i = 0; i < CountProjects; ++i)
            {
                if (Projects[i].ID == id)
                {
                    int Length = Projects[i].GetBudgetsIds().Length;
                    Arr = new int[Length];
                    Arr = Projects[i].GetBudgetsIds();

                    break;
                }
            }

            return Arr;
        }
    }
}
