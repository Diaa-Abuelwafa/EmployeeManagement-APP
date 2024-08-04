using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class HourlyEmployee : Employee
    {
        public double HoursWorked { get; set; }
        public double Rate { get; set; }

        public void AddHours()
        {
            // To Add Hours To This Employee
        }

        public override double CalculatePayyRoll()
        {
            return Rate * HoursWorked;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("The Type Is Hourly Employee");
            Console.WriteLine($"The Hours Worked : {this.HoursWorked}");
            Console.WriteLine($"The Rate : {this.Rate}");
            Console.WriteLine($"The PayRoll : {this.CalculatePayyRoll()}");
        }

        public override void SetValuesOfMember()
        {
            base.SetValuesOfMember();

            double HoursWorked;
            while (true)
            {
                Console.WriteLine("Enter How Much Hours The Hourly Employee Worked");
                bool Flag3 = double.TryParse(Console.ReadLine(), out HoursWorked);

                if (Flag3 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For Numbers Of Hours Worked"); ;
                }
            }

            this.HoursWorked = HoursWorked;

            double Rate;
            while (true)
            {
                Console.WriteLine("Enter Rate The Hourly Employee Worked");
                bool Flag3 = double.TryParse(Console.ReadLine(), out Rate);

                if (Flag3 == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter A Numeric Value For Value Of Rate"); ;
                }
            }

            this.Rate = Rate;
        }
        public override int PushEditedItems()
        {
            int CountItems = base.PushEditedItems();
            Console.WriteLine("6 - Edit Hours Worked");
            Console.WriteLine("7 - Edit Rate");

            return CountItems + 2;
        }

        public override int EditMember(int choice, string editedvalue)
        {
            if (choice < 6)
            {
                base.EditMember(choice, editedvalue);
                return 1;
            }
            else if (choice == 6)
            {
                double realeditedvalue;
                bool Flag1 = double.TryParse(editedvalue, out realeditedvalue);

                if (Flag1 == true)
                {
                    this.HoursWorked = realeditedvalue;
                    return 1;
                }
                else
                {
                    Console.WriteLine("This Value Cannot Be Hours Worked");
                }
            }
            else
            {
                double realeditedvalue;
                bool Flag1 = double.TryParse(editedvalue, out realeditedvalue);

                if (Flag1 == true)
                {
                    this.Rate = realeditedvalue;
                    return 1;
                }
                else
                {
                    Console.WriteLine("This Value Cannot Be The Rate");
                }
            }

            return 0;
        }

    }
}
