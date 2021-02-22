using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleLoanManager : ILoanManager
    {
        public void calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }

        public void printLoan()
        {
            throw new NotImplementedException();
        }
    }
}
