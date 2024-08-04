using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class Volunteer : StaffMember
    {
        public double AmountOfValue { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("The Type Is Volunteer");
            Console.WriteLine($"The Amount Value : {this.AmountOfValue}");
            Console.WriteLine($"The PayRoll : {this.CalculatePayyRoll()}");
        }

        public override double CalculatePayyRoll()
        {
            return AmountOfValue;
        }

        public override void SetValuesOfMember()
        {
            base.SetValuesOfMember();

            double AmountOfValue;
            while (true)
            {
                Console.WriteLine("Enter The Amount Of Value For The Volunteer");
                bool Flag3 = double.TryParse(Console.ReadLine(), out AmountOfValue);

                if (Flag3 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For Amount Of Value For The Volunteer"); ;
                }
            }

            this.AmountOfValue = AmountOfValue;
        }

        public override int PushEditedItems()
        {
            int CountItems = base.PushEditedItems();
            Console.WriteLine("5 - Edit Amount Of Value");

            return CountItems + 1;
        }

        public override int EditMember(int choice, string editedvalue)
        {
            if (choice < 5)
            {
                this.EditCommonItems(choice, editedvalue);
                return 1;
            }
            else
            {
                double realeditedvalue;
                bool Flag1 = double.TryParse(editedvalue, out realeditedvalue);

                if (Flag1 == true)
                {
                    this.AmountOfValue = realeditedvalue;
                    return 1;
                }
                else
                {
                    Console.WriteLine("This Value Cannot Be Amount Of Value");
                }
            }

            return 0;
        }
    }
}
