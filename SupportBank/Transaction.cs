using System;

namespace SupportBank
{
    public class Transaction
    {
        public DateTime Date { get; private set; }
        public Account AccountTo { get; private set; }
        public Account AccountFrom { get; private set; }
        public float Amount { get; private set; } 
        public string Narrative { get; private set; }
        
        public Transaction(DateTime date, Account accountTo, Account accountFrom, float amount, string narrative)
        {
            Date = date;
            AccountTo = accountTo;
            AccountFrom = accountFrom;
            Amount = amount;
            Narrative = narrative;
        }
        
    }
}