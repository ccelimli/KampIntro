using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class MortgageLoanManager : ILoanManager
    {
        public void calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }

        public void printLoan()
        {
            throw new NotImplementedException();
        }
    }
}
