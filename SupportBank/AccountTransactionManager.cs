using System;
using System.Collections.Generic;

namespace SupportBank
{
    public class AccountTransactionManager
    {
        // Stores Accounts and transactions
        // Generates reports

        public List<Transaction> Transactions = new List<Transaction>();
        private Dictionary<string, Account> _accounts = new Dictionary<string, Account>();

        public void GenerateAccountsAndTransactions(string path)
        {
            foreach (var csvRow in TransactionImporter.Read(path))
            {
                if (csvRow["Amount"] == "Amount") continue; // FIX ME.
                
                // Check/create accounts (to and from)
                var sender = CheckAndCreateAccount(csvRow["Sender"]);
                var receiver = CheckAndCreateAccount(csvRow["Receiver"]);
                
                // Create Transaction (they aren't validated)
                var newTransaction = CreateTransaction(csvRow["Date"], sender, receiver, "reference", float.Parse(csvRow["Amount"]));
                sender.AddTransaction(newTransaction);
                receiver.AddTransaction(newTransaction);
            }
        }

        private Account CheckAndCreateAccount(string name)
        {
            // Determine if exists
            Account value;
            if (_accounts.TryGetValue(name, out value))
            {
                return value;
            }
            
            // Create if doesn't exist
            Account newAccount = new Account(name);
            
            // Store in dictionary
            _accounts.Add(name, newAccount);
            
            return newAccount;
        }

        private Transaction CreateTransaction(string date, Account sender, Account receiver, string reference,
            float amount)
        {
            // We can only validate a transactions uniquness by comparing all its values. 
            // The transaction constructor is looking for Date/Time for the date, and a float for the amount
            // Where do we convert to correct data type? (extension method?, here?, Importer? seperate varifier?)
            // Create transaction
            // store transaction
            var newTransaction = new Transaction(date, sender, receiver, reference,amount);
            Transactions.Add(newTransaction);
            
            return newTransaction;
        }

        
        public void GenerateReport()
        {
            // List all (prints all names along with total amounts)
            foreach (var account in _accounts)
            {
                // show list of names with balance
                string TextToDisplay =
                    $"Name :{account.Value.Name} \n" +
                    $"Balance :{account.Value.Balance.ToString("0.00")} \n";

                Console.WriteLine(TextToDisplay);



            }
        }
        
        public void GenerateReport(Account specificUser)
        {
            Console.WriteLine(
                $"\nName : {specificUser.Name} \n" +
                $"Balance : {specificUser.Balance.ToString("0.00")} \n" +
                $"---TRANSACTIONS---"
                );
            // List Account (prints every transaction involving a specific account)
            foreach (var transaction in specificUser.GetTransactions())
            {
                string TextToDisplay =
                    $"From : {transaction.AccountFrom.Name}, " +
                    $"To : {transaction.AccountTo.Name}, " +
                    $"Date :{transaction.Date} \n" +
                    $"Reference :{transaction.Narrative} \n" +
                    $"Amount: {transaction.Amount} \n \n \n";
                Console.WriteLine(TextToDisplay);
            }
        }
        
        public void GenerateReport(string specificUser)
        {
            GenerateReport(_accounts[specificUser]);
        }
    }
}