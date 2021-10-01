using System;

namespace SupportBank
{
    public class Transaction
    {
        public string Date { get; private set; }
        public Account AccountTo { get; private set; }
        public Account AccountFrom { get; private set; }
        public float Amount { get; private set; } 
        public string Narrative { get; private set; }
        
        public Transaction(string date, Account accountTo, Account accountFrom, string narrative, float amount)
        {
            Date = date;
            AccountTo = accountTo;
            AccountFrom = accountFrom;
            Amount = amount;
            Narrative = narrative;
        }
        
    }
}