using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class InsuranceBill : InterestBill, IBill
    {
        public void DisplayBill()
        {
            Console.WriteLine($"BILL ID: {BillID}");
            Console.WriteLine($"BILL NAME: {BillName}");
            Console.WriteLine($"BILL TYPE: {Type}");
            Console.WriteLine($"BILL AMOUNT: Php{Amount:F2}");
            Console.WriteLine($"TOTAL AMOUNT: Php{CalculateTotalAmount():F2}");
        }
    }

}
