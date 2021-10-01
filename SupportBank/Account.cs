using System.Collections.Generic;
using SupportBank;

namespace SupportBank
{
    public class Account
    {
        public static int ActiveAccounts { get; private set; } // Ask Ben: property or field

        private List<Transaction> _transactions = new List<Transaction>();  // Ask Ben: Property or method?
        public int Id { get; private set; }
        public float Balance { get; private set; }
        public string Name { get; set; }
        
        public void AddTransaction(Transaction newTransaction)
        {
            // Add transaction to list;
            _transactions.Add(newTransaction);
            
            // Adjust Credit/ 
            if (newTransaction.AccountTo == this)
            {
                Balance -= newTransaction.Amount;
            }
            else
            {
                Balance += newTransaction.Amount;
            }
        }

        public List<Transaction> GetTransactions()
        {
            return _transactions;
        }

        public Account(string name)
        {
            ActiveAccounts++;
            this.Id = ActiveAccounts;
            this.Name = name;
        }
    }
}
