using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class ExecutiveEmployee : SalariedEmployee
    {
        public double Bonus { get; set; }

        public void AddBonus()
        {
            // To Add Bonus To The Executive Employee
        }

        public override double CalculatePayyRoll()
        {
            return this.Salary + this.Bonus;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("The Type Is Executive Employee");
            Console.WriteLine($"The Salary : {this.Salary}");
            Console.WriteLine($"The Bonus : {this.Bonus}");
            Console.WriteLine($"The PayRoll : {this.CalculatePayyRoll()}");
        }

        public override void SetValuesOfMember()
        {
            base.SetValuesOfMember();

            double Bonus;
            while (true)
            {
                Console.WriteLine("Enter The Bonus Value For The Executive Employee");
                bool Flag3 = double.TryParse(Console.ReadLine(), out Bonus);

                if (Flag3 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For Value Of Bonus For The Executive Employee"); ;
                }
            }

            this.Bonus = Bonus;
        }

        public override int PushEditedItems()
        {
            int CountItems = base.PushEditedItems();
            Console.WriteLine("7 - Edit Bonus");

            return CountItems + 1;
        }

        public override int EditMember(int choice, string editedvalue)
        {
            if (choice < 7)
            {
                base.EditMember(choice, editedvalue);
                return 1;
            }
            else
            {
                double realeditedvalue;
                bool Flag1 = double.TryParse(editedvalue, out realeditedvalue);

                if (Flag1 == true)
                {
                    this.Bonus = realeditedvalue;
                    return 1;
                }
                else
                {
                    Console.WriteLine("This Value Cannot Be The Bonus");
                }
            }

            return 0;
        }
    }
}
