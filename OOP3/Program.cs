using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            TradespeopleLoan tradespeopleLoan = new TradespeopleLoan();
            
            AppealManager appealManager = new AppealManager();
            ILoggerService fileloggerService = new FileLoggerService();
            appealManager.Appeal(consumerLoanManager,new DatabaseLoggerService()); // Buradaki new yukarıda yaptıklarımızla aynı
            appealManager.Appeal(vehicleLoanManager, fileloggerService);
            appealManager.Appeal(tradespeopleLoan, new SmsLoggerService());

            // appealManager.Appeal(mortgageLoanManager);

            List<ILoanManager> loans = new List<ILoanManager>() {consumerLoanManager,vehicleLoanManager};
            //appealManager.LoanElucidating(loans);
        }
    }
}
