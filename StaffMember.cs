using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class StaffMember
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"The ID : {this.ID}");
            Console.WriteLine($"The Name : {this.Name}");
            Console.WriteLine($"The Phone Number : {this.PhoneNumber}");
            Console.WriteLine($"The Email : {this.Email}");
        }

        public virtual double CalculatePayyRoll()
        {
            return 0.0;
        }

        public virtual void SetValuesOfMember()
        {
            // [1]
            int MemeberId;
            while (true)
            {
                Console.WriteLine("Enter The ID Of The Member");
                bool Flag1 = int.TryParse(Console.ReadLine(), out MemeberId);

                if (Flag1 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For Member ID");
                }
            }

            // ==
            this.ID = MemeberId;
            // ==

            // [2]
            Console.WriteLine("Enter The Name Of The Member");
            string MemberName = Console.ReadLine();

            // ==
            this.Name = MemberName;
            // ==

            // [3]
            long MemeberPhoneNumber;
            while (true)
            {
                Console.WriteLine("Enter The Phone Number Of The Member");
                bool Flag2 = long.TryParse(Console.ReadLine(), out MemeberPhoneNumber);

                if (Flag2 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For Member Phone Number");
                }
            }

            // ==
            this.PhoneNumber = MemeberPhoneNumber;
            // ==

            // [4]
            Console.WriteLine("Enter The Email Of The Member");
            string MemberEmail = Console.ReadLine();

            // ==
            this.Email = MemberEmail;
            // ==
        }

        public virtual int PushEditedItems()
        {           
            Console.WriteLine("What Are You Need To Modify");
            Console.WriteLine("1 - ID");
            Console.WriteLine("2 - Name");
            Console.WriteLine("3 - Phone");
            Console.WriteLine("4 - Email");

            int CountItems = 4;

            return CountItems;
        }

        public void EditCommonItems(int choice, string editedvalue)
        {
            switch (choice)
            {
                case 1:
                    int realeditedvalue;
                    bool Flag1 = int.TryParse(editedvalue, out realeditedvalue);

                    if (Flag1 == true)
                    {
                        this.ID = realeditedvalue;
                    }
                    else
                    {
                        Console.WriteLine("This Value Cannot Be ID");
                    }

                    break;

                case 2:

                    this.Name = editedvalue;

                    break;

                case 3:

                    long realeditedvalue2;

                    bool Flag2 = long.TryParse(editedvalue, out realeditedvalue2);

                    if (Flag2 == true)
                    {
                        this.PhoneNumber = realeditedvalue2;
                    }
                    else
                    {
                        Console.WriteLine("This Value Cannot Be Phone Number");
                    }

                    break;

                case 4:

                    this.Email = editedvalue;

                    break;
            }
        }

        public virtual int EditMember(int choice, string editedvalue)
        {
            return 0;
        }
    }
}
