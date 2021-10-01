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

        public void GenerateAccountsAndTransactions(string path)
        {
            foreach (var csvRow in TransactionImporter.Read(path))
            {
                Console.WriteLine(csvRow["Amount"]);
            }
        }
    }
}