using System.Collections.Generic;

namespace SupportBank
{
    public class AccountTransactionManager
    {
        // Stores Accounts and transactions
        // Generates reports

        public List<Transaction> Transactions { get; set; }
        public List<Account> Accounts { get; set; }

        public void GenerateAccounts()
        {
            var csvReader = new CSVReader(@"../fileToOpen.csv");
            
            foreach (var csvRow in csvReader)
            {
                
            }
        }


    }
}