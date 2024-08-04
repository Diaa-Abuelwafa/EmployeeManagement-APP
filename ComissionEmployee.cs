using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class ComissionEmployee : Employee
    {
        public double Target { get; set; }

        public override double CalculatePayyRoll()
        {
            return (5 / 100) * Target;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("The Type Is Comission Employee");
            Console.WriteLine($"The Target : {this.Target}");
            Console.WriteLine($"The PayRoll : {this.CalculatePayyRoll()}");
        }

        public override void SetValuesOfMember()
        {
            base.SetValuesOfMember();

            double Target;
            while (true)
            {
                Console.WriteLine("Enter The Target Value For The Comission Employee");
                bool Flag3 = double.TryParse(Console.ReadLine(), out Target);

                if (Flag3 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For Value Of Target For The Comission Employee"); ;
                }
            }

            this.Target = Target;
        }

        public override int PushEditedItems()
        {
            int CountItems = base.PushEditedItems();
            Console.WriteLine("6 - Edit Target");

            return CountItems + 1;
        }

        public override int EditMember(int choice, string editedvalue)
        {
            if (choice < 6)
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
                    this.Target = realeditedvalue;
                    return 1;
                }
                else
                {
                    Console.WriteLine("This Value Cannot Be The Target");
                }
            }

            return 0;
        }
    }
}
