using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface ILoanManager // Interfacelerde okunurluğu arttırmak için ismin önüne I koyarız.
    {
        void calculate();
        void printLoan();
        
    }
}
/* Notlar:
 *  1-Interfaceleri birbirinin altenatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
 */