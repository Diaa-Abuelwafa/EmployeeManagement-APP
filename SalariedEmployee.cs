using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class SalariedEmployee : Employee
    {
        public double Salary { get; set; }

        public override double CalculatePayyRoll()
        {
            return Salary;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("The Type Is Salaried Employee");
            Console.WriteLine($"The Salary : {this.Salary}");
            Console.WriteLine($"The PayRoll : {this.CalculatePayyRoll()}");
        }

        public override void SetValuesOfMember()
        {
            base.SetValuesOfMember();

            double Salary;
            while (true)
            {
                Console.WriteLine("Enter The Salary For The Salaried Employee");
                bool Flag3 = double.TryParse(Console.ReadLine(), out Salary);

                if (Flag3 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For The Salary Of The Salaried Employee"); ;
                }
            }

            this.Salary = Salary;
        }

        public override int PushEditedItems()
        {
            int CountItems = base.PushEditedItems();
            Console.WriteLine("6 - Edit Slary");

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
                    this.Salary = realeditedvalue;
                    return 1;
                }
                else
                {
                    Console.WriteLine("This Value Cannot Be The Salary");
                }
            }

            return 0;
        }
    }
}
