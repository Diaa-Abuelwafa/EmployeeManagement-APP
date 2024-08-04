using Project03OOP;

namespace Projecr03OOP
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("=============== Employee Management Application ===============");

            // Create New Object From [Staff - DepartmentsList - ProjectsList]
            Staff TheStaff = new Staff();
            DepartmentsList TheDepartments = new DepartmentsList();
            ProjectsList TheProjects = new ProjectsList();

            while(true)
            {
                // Options Menu
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("--- Departments ---");
                Console.WriteLine("1 - Add New Department");
                Console.WriteLine("2 - Print All Departments Information");

                Console.WriteLine("--- Staff ---");
                Console.WriteLine("3 - Add New Member");
                Console.WriteLine("4 - Print All Members");
                Console.WriteLine("5 - Calculate PayRoll For All Members");
                Console.WriteLine("6 - Delete Member");
                Console.WriteLine("7 - Edit Member");
                Console.WriteLine("8 - Search For Member");

                Console.WriteLine("--- Project ---");
                Console.WriteLine("9 - Add New Project");
                Console.WriteLine("10 - Print All Projects");
                Console.WriteLine("11 - Add Budget to Existing Project");
                Console.WriteLine("12 - Increase Budget to Existing Project");
                Console.WriteLine("-------------");

                int Choice;

                while (true)
                {
                    Console.WriteLine("Choose Number Between 1 To 12");
                    bool Flag1 = int.TryParse(Console.ReadLine(), out Choice);

                    if (Flag1 == true && Choice >= 1 && Choice <= 12)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Valid Numeric Value Between 1 To 10");
                    }
                }

                switch (Choice)
                {
                    case 1:
                        int DeptId;

                        while (true)
                        {
                            Console.WriteLine("Enter The New ID For This Department");
                            bool Flag2 = int.TryParse(Console.ReadLine(), out DeptId);

                            if (Flag2 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter Valid Numeric Value");
                            }
                        }

                        Console.WriteLine("Enter The New Name For This Department");
                        string DeptName = Console.ReadLine();

                        TheDepartments.AddNewDepartment(DeptId, DeptName);

                        break;

                    case 2:

                        if (TheDepartments.GetCountOfDepartments() == 0)
                        {
                            Console.WriteLine("Sorry : There are no Departments currently");
                        }
                        else
                        {
                            TheDepartments.PrintAllDepartments();
                        }
                        
                        break;

                    case 3:
                        
                        string MemberType;

                        while(true)
                        {
                            Console.WriteLine("Enter The Type Of Member [Employee / Volunteer]");
                            MemberType = Console.ReadLine();

                            if(MemberType == "Employee" || MemberType == "Volunteer")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Choose From Employee Or Volunteer");
                            }
                        }

                        if(MemberType == "Employee")
                        {
                            while(true)
                            {
                                Console.WriteLine("Enter The Type Of Employee [Hourly / Salaried / Executive / Comission]");
                                MemberType = Console.ReadLine();

                                if (MemberType == "Hourly" || MemberType == "Salaried" || MemberType == "Executive" || MemberType == "Comission")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please Choose From Hourly Or Salaried Or Executive Or Comission");
                                }
                            }
                        }
                        else
                        {
                            MemberType = "Volunteer";
                        }

                        int DeptId1Temp;
                        int DeptId1 = -1; // I will Pass It

                        while (true)
                        {
                            Console.WriteLine("Enter Department ID For This Member And Must The ID From Departments IDs");
                            bool Flag3 = int.TryParse(Console.ReadLine(), out DeptId1Temp);
                            bool Flag4 = false;

                            if(Flag3 == true)
                            {
                                int[] Arr = TheDepartments.GetIdsDepartments();

                                for (int i = 0; i < Arr.Length; ++i)
                                {
                                    if(Arr[i] == DeptId1Temp)
                                    {
                                        DeptId1 = DeptId1Temp;
                                        Flag4 = true;
                                        break;
                                    }
                                }

                                if(Flag4 == true)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"There Is No Department With This ID {DeptId1Temp}");
                                    break;
                                }
                            }
                        }

                        if(MemberType is not null && DeptId1 != -1)
                        {
                            TheStaff.AddNewMember(MemberType, DeptId1);
                        }

                        break;

                    case 4:

                        if(TheStaff.GetCountMembers() == 0)
                        {
                            Console.WriteLine("Sorry : There are no members currently");
                        }
                        else
                        {
                            TheStaff.ShowAllMembers();
                        }

                        break;

                    case 5:

                        if (TheStaff.GetCountMembers() == 0)
                        {
                            Console.WriteLine("Sorry : There are no members currently");
                        }
                        else
                        {
                            Console.WriteLine($"The Total PayRoll Of All Members = {TheStaff.CalculateAllPayRolls()}");
                        }                       

                        break;

                    case 6:

                        if(TheStaff.GetCountMembers() == 0)
                        {
                            Console.WriteLine("Sorry : There are no members currently To Delete");
                            break;
                        }

                        int MemeberID2;

                        while(true)
                        {
                            Console.WriteLine("Enter The Member ID You Want To Delete");
                            bool Flag5 = int.TryParse(Console.ReadLine(), out MemeberID2);

                            if(Flag5 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter Numeric Value For ID");
                            }
                        }

                        int Temp2 = TheStaff.DeleteMember(MemeberID2);

                        if(Temp2 == 1)
                        {
                            Console.WriteLine("Delete Operation Is Done");
                        }
                        else
                        {
                            Console.WriteLine($"Delete Operation Is Not Done Because There Isn't Member With This ID {MemeberID2}");
                        }

                        break;

                    case 7:

                        if(TheStaff.GetCountMembers() == 0)
                        {
                            Console.WriteLine("Sorry : There are no members currently To Modify");
                            break;
                        }

                        int MemberId4;
                        while(true)
                        {
                            Console.WriteLine("Enter The Member ID Who You Need To Modify His Data");
                            bool Flag6 = int.TryParse(Console.ReadLine(), out MemberId4);

                            if(Flag6 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter The Numeric Value For The ID");
                            }
                        }

                        int[] Arr1 = TheStaff.GetMembersIds();
                        int MemberIdToModify = -1;

                        for(int i = 0; i < Arr1.Length; ++i)
                        {
                            if (Arr1[i] == MemberId4)
                            {
                                MemberIdToModify = Arr1[i];
                                break;
                            }
                        }

                        if(MemberIdToModify != -1)
                        {
                            int CountTemp = TheStaff.PushItems(MemberIdToModify);

                            int Choice3;
                            while(true)
                            {
                                Console.WriteLine("---------------");
                                Console.WriteLine("Enter Yor Choice");
                                bool Flag17 = int.TryParse(Console.ReadLine(), out Choice3);

                                if(Flag17 == true && Choice3 >= 1 && Choice3 <= CountTemp)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter The Numeric Value For The Choice");

                                }
                            }

                            Console.WriteLine("Enter The New Value");
                            string EditedValue = Console.ReadLine();

                            TheStaff.EditMember(MemberIdToModify, Choice3, EditedValue);
                        }
                        else
                        {
                            Console.WriteLine($"Sorry There Are No Members With This ID {MemberIdToModify}");
                        }

                        break;

                    case 8:

                        if (TheStaff.GetCountMembers() == 0)
                        {
                            Console.WriteLine("Sorry : There are no members currently To Search");
                            break;
                        }

                        int Choice4;

                        while(true)
                        {
                            Console.WriteLine("What Type Do You Want to Search Through ?");
                            Console.WriteLine("--- Choose Number From 1 To 4 ---");
                            Console.WriteLine("1 - ID");
                            Console.WriteLine("2 - Name");
                            Console.WriteLine("3 - Phone Number");
                            Console.WriteLine("4 - Email");
                            Console.WriteLine("-----");

                            bool Flag44 = int.TryParse(Console.ReadLine(), out Choice4);

                            if(Flag44 == true && Choice4 >= 1 && Choice4 <= 4)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Wrong !  Please Try Again");
                            }
                        }

                        TheStaff.SearchMember(Choice4);

                        break;

                    case 9:
                        // [1]
                        int ProjId;
                        
                        while(true)
                        {
                            Console.WriteLine("Enter The New Project ID");
                            bool Flag6 = int.TryParse(Console.ReadLine(), out ProjId);

                            if(Flag6 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Enter The Numeric Value For ID");
                            }
                        }

                        // [2]
                        Console.WriteLine("Enter The New Project Location");
                        string ProjLocation = Console.ReadLine();

                        // [3]
                        double ProjCurrentCost;

                        while (true)
                        {
                            Console.WriteLine("Enter The New Project Current Cost");
                            bool Flag7 = double.TryParse(Console.ReadLine(), out ProjCurrentCost);

                            if (Flag7 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Enter The Numeric Value For Current Cost");
                            }
                        }


                        // [4]
                        int EmpId;
                        bool FlagReal = false;

                        while (true)
                        {
                            Console.WriteLine("Enter The ID For Empolyee Who You Need To Be A Manager For This Project");
                            Console.WriteLine("The ID Must Match With Any Employee At The Sttaf");

                            bool Flag6 = int.TryParse(Console.ReadLine(), out EmpId);
                            bool Flag7 = false;

                            if (Flag6 == true)
                            {
                                int[] Arr = TheStaff.GetMembersIds();

                                for(int i = 0; i < Arr.Length; ++i)
                                {
                                    if(Arr[i] == EmpId)
                                    {
                                        Flag7 = true;
                                        FlagReal = true;
                                        break;
                                    }
                                }

                                if (Flag7 == true)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("The ID Value Is Not Matched With The Members IDs");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Enter The Numeric Value For ID");
                            }
                        }

                        if(FlagReal == false)
                        {
                            break;
                        }

                        // [5]
                        
                        int BudgetsNums;

                        while(true)
                        {
                            Console.WriteLine("Enter How Much Budgets Will Be In This Project");
                            bool Flag8 = int.TryParse(Console.ReadLine(), out BudgetsNums);

                            if(Flag8 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter The Numeric Value Fon Numbers Of Budgets");
                            }
                        }

                        Budget[] BudgetsList = new Budget[1];

                        if (BudgetsNums > 0)
                        {
                            BudgetsList = new Budget[BudgetsNums];

                            for (int i = 0; i < BudgetsNums; ++i)
                            {
                                BudgetsList[i] = new Budget();

                                int BudgetId;
                                while(true)
                                {
                                    Console.WriteLine($"Enter The ID Of The Budget {i + 1}");
                                    bool Flag9 = int.TryParse(Console.ReadLine(), out BudgetId);

                                    if(Flag9 == true)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please Enter The Numeric Value For The Budget ID");
                                    }
                                }

                                double BudgetValue;
                                while(true)
                                {
                                    Console.WriteLine("Enter The Value Of This Budget");
                                    bool Flag10 = double.TryParse(Console.ReadLine(), out BudgetValue);

                                    if (Flag10 == true)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Please Enter The Numeric Value For The Budget ID");
                                    }
                                }

                                BudgetsList[i].ID = BudgetId;
                                BudgetsList[i].Value = BudgetValue;
                            }
                        }

                        TheProjects.AddNewProject(ProjId, ProjLocation, ProjCurrentCost, EmpId, BudgetsList);

                        break;

                    case 10:

                        if(TheProjects.GetNumbersOfProjects() == 0)
                        {
                            Console.WriteLine("Sorry : There are no Projects currently");
                            break;
                        }

                        TheProjects.PrintAllProjects();

                        break;

                    case 11:

                        if (TheProjects.GetNumbersOfProjects() == 0)
                        {
                            Console.WriteLine("Sorry : There are no Projects currently");
                            break;
                        }

                        // [1]
                        int ProjId2;
                        while(true)
                        {
                            Console.WriteLine("Enter The Project ID You Want To Add To");
                            bool Flag1 = int.TryParse(Console.ReadLine(), out ProjId2);

                            if(Flag1 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter The Numeric Value For The ID");
                            }
                        }

                        int[] Arr77 = TheProjects.GetProjectsIds();
                        bool Flag77 = false;

                        for (int i = 0; i < Arr77.Length; ++i)
                        {
                            if (Arr77[i] == ProjId2)
                            {
                                Flag77 = true;
                                break;
                            }
                        }

                        if(Flag77 == false)
                        {
                            Console.WriteLine($"There Are Not Project With This ID {ProjId2}");
                            break;
                        }

                        //[2]
                        int BudgetId77;
                        while (true)
                        {
                            Console.WriteLine("Enter New ID For This New Budget");
                            bool Flag78 = int.TryParse(Console.ReadLine(), out BudgetId77);

                            if (Flag78 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter Numeric Value For Budget ID");
                            }
                        }

                        // [3]
                        double BudgetValue77;
                        while (true)
                        {
                            Console.WriteLine("Enter Value For This New Budget");
                            bool Flag79 = double.TryParse(Console.ReadLine(), out BudgetValue77);

                            if (Flag79 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter Numeric Value For Budget Value");
                            }
                        }

                        TheProjects.AddBudget(ProjId2, BudgetId77, BudgetValue77);

                        break;

                    case 12:

                        if (TheProjects.GetNumbersOfProjects() == 0)
                        {
                            Console.WriteLine("Sorry : There are no Projects currently");
                            break;
                        }

                        // [1]
                        int Projectid88;
                        while(true)
                        {
                            Console.WriteLine("Enter The Project ID Which You Need To Increase Its Budget");
                            bool Flag88 = int.TryParse(Console.ReadLine(), out Projectid88);

                            if(Flag88 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter The Numeric Value For The Project ID");
                            }
                        }

                        int[] Arr88 = TheProjects.GetProjectsIds();
                        bool Flag89 = false;

                        for (int i = 0; i < Arr88.Length; ++i)
                        {
                            if (Arr88[i] == Projectid88)
                            {
                                Flag89 = true;
                                break;
                            }
                        }

                        if(Flag89 == false)
                        {
                            Console.WriteLine($"There Are Not Projects With This ID {Projectid88}");
                            break;
                        }

                        // [2]
                        int BudgetId88;
                        while (true)
                        {
                            Console.WriteLine("Enter The Budget ID Which You Need To Increase The Value Of It");
                            bool Flag88 = int.TryParse(Console.ReadLine(), out BudgetId88);

                            if (Flag88 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter The Numeric Value For The Budget ID");
                            }
                        }

                        int[] Arr90 = TheProjects.GetBudgetsIdsOfProject(Projectid88);
                        bool Flag90 = false;

                        for (int i = 0; i < Arr90.Length; ++i)
                        {
                            if (Arr90[i] == BudgetId88)
                            {
                                Flag90 = true;
                                break;
                            }
                        }

                        if(Flag90 == false)
                        {
                            Console.WriteLine($"Sorry : There Are Not Budget With This ID {BudgetId88}");
                            break;
                        }

                        // [3]
                        double AddsValue;
                        while (true)
                        {
                            Console.WriteLine("Enter The Adds Value You Need To Add To The Budget");
                            bool Flag17 = double.TryParse(Console.ReadLine(), out AddsValue);

                            if (Flag17 == true)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Enter The Numeric Value For The Adds Value Of The Budget");
                            }
                        }

                        TheProjects.IncreaseBudgetForExistingProject(Projectid88, BudgetId88, AddsValue);

                        break;
                }

                Console.WriteLine("----------");
                Console.WriteLine("Are You Need To Make Another Operation ?");
                Console.WriteLine("Press y If You Need");
                Console.WriteLine("Press Any Button If You Don't Need");

                char Choice2 = char.Parse(Console.ReadLine());

                if(Choice2 != 'y')
                {
                    break;
                }
            }
        }
    }
}