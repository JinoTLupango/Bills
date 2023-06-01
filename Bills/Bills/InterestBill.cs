using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    abstract class InterestBill : Bill
    {
        protected const decimal INTEREST = 0.10m;

        public override decimal CalculateTotalAmount()
        {
            return Amount * (1 + INTEREST);
        }
    }

}
