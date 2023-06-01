using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    abstract class Bill
    {
        public int BillID { get; set; }
        public string BillName { get; set; }
        public BillType Type { get; set; }
        public decimal Amount { get; set; }

        public abstract decimal CalculateTotalAmount();
    }

}
