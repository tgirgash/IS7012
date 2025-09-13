using System;
using System.Collections.Generic;

namespace Exercise1.Models
{
    public class AccountHolder
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public List<BankAccount> BankAccounts { get; set; }
    }
}
