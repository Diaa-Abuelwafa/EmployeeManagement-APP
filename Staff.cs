using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class Staff
    {
        StaffMember[] Members;
        int CountMembers;

        public Staff()
        {
            Members = new StaffMember[20];
            CountMembers = 0;
        }

        public void AddNewMember(string type, int deptid)
        {
            switch(type)
            {
                case "Hourly":
                    Members[CountMembers] = new HourlyEmployee();                 
                    break;

                case "Salaried":
                    Members[CountMembers] = new SalariedEmployee();
                    break;

                case "Executive":
                    Members[CountMembers] = new ExecutiveEmployee();
                    break;

                case "Comission":
                    Members[CountMembers] = new ComissionEmployee();
                    break;

                case "Volunteer":
                    Members[CountMembers] = new Volunteer();
                    break;
            }

            Members[CountMembers].SetValuesOfMember();

            CountMembers++;
        }

        public int PushItems(int id)
        {
            int indx = -1;

            for(int i = 0; i < CountMembers; ++i)
            {
                if (Members[i].ID == id)
                {
                    indx = i;
                }
            }

            return Members[indx].PushEditedItems();
        }

        public void EditMember(int id, int choice, string editedvalue)
        {
            int indx = -1;

            for (int i = 0; i < CountMembers; ++i)
            {
                if (Members[i].ID == id)
                {
                    indx = i;
                }
            }

            int Result = Members[indx].EditMember(choice, editedvalue);

            if(Result == 1)
            {
                Console.WriteLine("The Edit Operation Is Done");
            }
            else
            {
                Console.WriteLine("The Edit Operation Is Not Done");
            }
        }

        public int DeleteMember(int id)
        {
            int Indx = -1;

            for(int i = 0; i < CountMembers; ++i)
            {
                if (Members[i].ID == id)
                {
                    Indx = i;
                }
            }

            if(Indx == -1)
            {
                return 0;
            }

            // Shallow Copy
            for(int i = Indx; i < CountMembers - 1; ++i)
            {
                Members[i] = Members[i + 1];
            }

            CountMembers--;

            return 1;
        }

        public int GetCountMembers()
        {
            return CountMembers;
        }

        public void SearchMemberProcess(int Choice, object obj)
        {
            switch(Choice)
            {
                case 1:

                    bool Flag1 = false;

                    int ID1 = (int)obj;

                    for(int i = 0; i < CountMembers; ++i)
                    {
                        if (Members[i].ID == ID1)
                        {
                            Flag1 = true;

                            Console.WriteLine("Yes We Have A Member With This ID");
                            Console.WriteLine("----------");

                            Members[i].Print();

                            break;
                        }
                    }

                    if(Flag1 == false)
                    {
                        Console.WriteLine("Sorry We Dont Have A Member With This ID");
                    }

;                    break;

                case 2:

                    bool Flag2 = false;

                    string Name1 = (string)obj;

                    for (int i = 0; i < CountMembers; ++i)
                    {
                        if (Members[i].Name == Name1)
                        {
                            Flag2 = true;

                            Console.WriteLine("Yes We Have A Member With This Name");
                            Console.WriteLine("----------");


                            Members[i].Print();

                            break;
                        }
                    }

                    if (Flag2 == false)
                    {
                        Console.WriteLine("Sorry We Dont Have A Member With This Name");
                    }

                    break;

                case 3:

                    bool Flag3 = false;

                    long PhoneNumber1 = (long)obj;

                    for (int i = 0; i < CountMembers; ++i)
                    {
                        if (Members[i].PhoneNumber == PhoneNumber1)
                        {
                            Flag3 = true;

                            Console.WriteLine("Yes We Have A Member With This Phone Number");
                            Console.WriteLine("----------");


                            Members[i].Print();

                            break;
                        }
                    }

                    if (Flag3 == false)
                    {
                        Console.WriteLine("Sorry We Dont Have A Member With This Phone Number");
                    }

                    break;

                case 4:

                    bool Flag4 = false;

                    string Email1 = (string)obj;

                    for (int i = 0; i < CountMembers; ++i)
                    {
                        if (Members[i].Email == Email1)
                        {
                            Flag4 = true;

                            Console.WriteLine("Yes We Have A Member With This Email");
                            Console.WriteLine("----------");


                            Members[i].Print();

                            break;
                        }
                    }

                    if (Flag4 == false)
                    {
                        Console.WriteLine("Sorry We Dont Have A Member With This Email");
                    }

                    break;

            }
        }

        public void SearchMember(int choice)
        {
            switch(choice)
            {
                case 1:
                    int MemberId1;

                    while(true)
                    {
                        Console.WriteLine("Enter The ID");
                        bool Flag1 = int.TryParse(Console.ReadLine(), out MemberId1);

                        if(Flag1 == true)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please Enter The Numeric Value For The ID");
                        }
                    }

                    SearchMemberProcess(1, MemberId1);

                    break;

                case 2:
                    Console.WriteLine("Enter The Name");
                    string MemberName = Console.ReadLine();

                    SearchMemberProcess(2, MemberName);

                    break;

                case 3:

                    long MemberPhoneNumber;

                    while (true)
                    {
                        Console.WriteLine("Enter The Phone Number");
                        bool Flag2 = long.TryParse(Console.ReadLine(), out MemberPhoneNumber);

                        if (Flag2 == true)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please Enter The Numeric Value For The Phone Number");
                        }
                    }

                    SearchMemberProcess(3, MemberPhoneNumber);

                    break;

                case 4:

                    Console.WriteLine("Enter The Email");
                    string MemberEmail = Console.ReadLine();

                    SearchMemberProcess(4, MemberEmail);

                    break;
            }
        }

        public void ShowAllMembers()
        {
            for(int i = 0; i < CountMembers; ++i)
            {
                Console.WriteLine($"---- Staff Member {i + 1} ----");
                Members[i].Print();
                Console.WriteLine("-------------------------------");
            }
        }

        public double CalculateAllPayRolls()
        {
            double Sum = 0.0;

            for(int i = 0; i < CountMembers; ++i)
            {
                Sum += Members[i].CalculatePayyRoll();
            }

            return Sum;
        }

        public int[] GetMembersIds()
        {
            int[] Arr = new int[CountMembers];

            for(int i = 0; i < CountMembers; ++i)
            {
                Arr[i] = Members[i].ID;
            }

            return Arr;
        }

        public void PrintMemberWithId(int id)
        {
            for(int i = 0; i < CountMembers; ++i)
            {
                if (Members[i].ID == id)
                {
                    Members[i].Print();
                    return;
                }
            }

            Console.WriteLine($"No Member Here With This ID {id}");
        }
    }
}
