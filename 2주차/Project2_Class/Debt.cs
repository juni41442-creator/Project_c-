using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2_Class
{
   class Debt
    {
        public int Amount { get; set; }
        public int DueDate { get; set; }

        public Debt(int amount, int dueDate)
        {
            Amount = amount;
            DueDate = dueDate;
        }
    }
}
