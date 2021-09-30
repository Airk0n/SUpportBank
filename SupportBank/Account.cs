using System.Collections.Generic;
using SupportBank;

namespace SupportBank
{
    public class Account
    {
        public static int ActiveAccounts { get; private set; } // Ask Ben: property or field
        
        private List<Transaction> _transactions;  // Ask Ben: Property or method?
        public int Id { get; private set; }
        public float Balance { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
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

        public Account(string firstName, string lastName)
        {
            ActiveAccounts++;
            this.Id = ActiveAccounts;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
