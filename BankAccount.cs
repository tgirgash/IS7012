using System;

namespace Exercise1.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountName { get; set; }

       
        public string AccountType { get; set; }
        public DateTime LastTransactionDate { get; set; }
        public int AccountHolderId { get; set; }
        public AccountHolder AccountHolder { get; set; }
    
    }
}

