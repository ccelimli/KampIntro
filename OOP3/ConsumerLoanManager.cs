using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerLoanManager : ILoanManager
    {
        public void calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void printLoan()
        {
            throw new NotImplementedException();
        }
    }
}
