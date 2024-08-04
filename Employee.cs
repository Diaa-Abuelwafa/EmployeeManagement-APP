using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class Employee : StaffMember
    {
        public int SocialSecurityNumber { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"The Social Security Number : {this.SocialSecurityNumber}");
        }

        public override double CalculatePayyRoll()
        {
            return 0.0;
        }

        public override void SetValuesOfMember()
        {
            base.SetValuesOfMember();
          
            int SocialSecurityNumber;
            while (true)
            {
                Console.WriteLine("Enter The Social Security Number For The Employee");
                bool Flag3 = int.TryParse(Console.ReadLine(), out SocialSecurityNumber);

                if (Flag3 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For Social Security Number Of This Employee"); ;
                }
            }

            this.SocialSecurityNumber = SocialSecurityNumber;
        }

        public override int PushEditedItems()
        {
            int CountItems = base.PushEditedItems();
            Console.WriteLine("5 - Edit Social Security Number");            

            return CountItems + 1;
        }

        public override int EditMember(int choice, string editedvalue)
        {
            if(choice < 5)
            {
                this.EditCommonItems(choice, editedvalue);
                return 1;
            }
            else
            {
                int realeditedvalue;
                bool Flag1 = int.TryParse(editedvalue, out realeditedvalue);

                if (Flag1 == true)
                {
                    this.SocialSecurityNumber = realeditedvalue;
                    return 1;
                }
                else
                {
                    Console.WriteLine("This Value Cannot Be Social Security Number");
                }
            }

            return 0;
        }
    }
}
