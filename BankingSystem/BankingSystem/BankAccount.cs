using System;
using System.Collections.Generic;
using System.Text;

namespace BankingSystem
{
   public class BankAccount
    {
        public BankAccount(int id,decimal balance = 0)
        {
            this.Id = id;
            this.Balance = balance;
        }


        public int Id { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Negative amount");
            }
            this.Balance += amount;
        }

    }
}
