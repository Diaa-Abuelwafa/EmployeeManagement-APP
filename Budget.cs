using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project03OOP
{
    internal class Budget : ICloneable
    {
        public int ID { get; set; }
        public double Value { get; set; }

        public void IncreaseBudget(double addsvalue)
        {
            this.Value += addsvalue;
        }

        public object Clone()
        {
            Budget BudgetTemp = new Budget();

            BudgetTemp.ID = this.ID;
            BudgetTemp.Value = this.Value;

            return BudgetTemp;
        }
    }
}
