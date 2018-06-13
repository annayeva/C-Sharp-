using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace red_assignment01
{
    class Customer
    {
        public List<Account> Accounts = new List<Account>(); //creating a list containing accounts


        // properties (automatic ones)
        public int CustomerId { get; set; }

        public DateTime DOB { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public DateTime SignupDate { get; set; }

        // Customer class Constructor (automatically called when the object is created)

        public Customer (string name, string email, DateTime dob, DateTime signupDate)
        {
           CustomerId = new Random().Next(1000); // generates a random one
           Name = name;
           Email = email;
           DOB = dob;
           SignupDate = signupDate;

        }

        // methods

        public void Info() // showing the personal info of a customer
        {

            Console.Write("customer info:\n Customer name: {0}\n Customer e-mail: {1}\n Customer date of birth: {2}\n Customer signup date:{3}\n", this.Name, this.Email, this.DOB, SignupDate);

        }

        public void CreateAccount() //on the call of the function creates a new account
        {
            Account ax = new Account(this.CustomerId); // must pass a customer ID as constructor requires 
            Accounts.Add(ax); // and adds it to the list of Accounts
        }

        public void DepositToAccount (decimal amount, int accountIndex) // passed deposit ammount and account index
        {

            Accounts[accountIndex].Deposit(amount); // from the list of Accounts select account with this index
                                                    // and run the Deposit method on it (passing the deposit amount)
        }

        public void ListAccounts() //listing all the accounts of a customer
        {

            foreach (Account item in Accounts) //for each account in the Accounts list run the Info function
            {
                item.Info(); // Info method is public and belongs to Account class
                            // it gives the info about customer ID, Account ID and a balance

            }

        }

        public void ListAccount (int accountIndex) //for an account in the Accounts list with index run the Info method
        {
            Accounts[accountIndex].Info(); // Info method is public and belongs to Account class
        }

       
    }
}
