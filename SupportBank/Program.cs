using System;
using System.Threading.Channels;
using Microsoft.VisualBasic.FileIO;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read CSV. (part 1)
            // Create accounts/check they exist (part 2)
            // Create Transactions (part 2)
            // Generate report(part 3)
            
            var atm = new AccountTransactionManager();
            atm.GenerateAccountsAndTransactions(@"./Transactions2014.csv");
            atm.GenerateReport();
            
            //(part 4 after push)


        }
    }
}