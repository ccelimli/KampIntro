using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager
    {
        //Method injection
        public void Appeal(ILoanManager loanManager,ILoggerService loggerService)
        {
            loanManager.calculate();
            loggerService.Log();
        }
        public void LoanElucidating(List<ILoanManager> loans) // Listeler aynı veri türünde çok sayıda veriyi içerebildiği için kullandık.
        {

            foreach (var item in loans)
            {
                item.calculate(); // listedeki her bir kredinin hesaplamasını yap
            }

        }
    }
}
