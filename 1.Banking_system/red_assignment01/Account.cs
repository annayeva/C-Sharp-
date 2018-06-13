using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace red_assignment01
{
    class Account
    {
        // properties (automatic ones)

        public string AccountId { get; set; }

        private decimal Balance { get; set; }

        public int CustomerId { get; set; }

        // Account class Constructor (automatically called when the object is created)
        public Account(int customerId) //customer ID is passed from the 
        {
            this.CustomerId = customerId;
            this.AccountId = Guid.NewGuid().ToString(); //generates a random ID
            this.Balance = 0; // when account is created it`s value is 0 by default
        }

        public void Deposit (decimal amount) // amount is passed via DepositToAccount method
        {
            this.Balance = this.Balance + amount; 
        }

        public bool Withdraw (decimal amount) // bool method checking if balance is high enough to withdraw money
        {
            if ( amount > Balance)
            {
                return false;
            }

            this.Balance = this.Balance - amount;

            return true;
            

        }

        public void Info () // shows the information about the the accont
        {
            Console.WriteLine("account info:\n customer Id - {0}\n account ID - {1}\n balance - {2}\n", this.CustomerId, this.AccountId, this.Balance);
        }



    }


}
