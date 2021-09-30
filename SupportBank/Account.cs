using System.Collections.Generic;
using SupportBank;

namespace SupportBank
{
    public class Account
    {
        public static int ActiveAccounts { get; private set; } // Ask Ben: property or field
        
        private List<Transaction> _transactions;  // Ask Ben: Property or method?
        public int Id { get; private set; }
        public float Debt { get; set; }
        public float Credit { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float TotalAmount => Credit - Debt;

        public bool AddTransaction()
        {
            return false;
        }
    }
}
