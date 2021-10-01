using System;
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
            foreach (var csvRow in CsvReader.Read(@"./Transactions2014.csv"))
            {
                Console.WriteLine(csvRow);
            }
        }


    }
}