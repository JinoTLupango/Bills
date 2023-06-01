using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var bill = new InsuranceBill
            {
                BillID = 12345,
                BillName = "PIONEER",
                Type = BillType.Insurance,
                Amount = 1000m
            };

            bill.DisplayBill();
            Console.ReadLine();
        }
        
    }

}
