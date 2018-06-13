using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace red_assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating a new customer called c1, constructor requires to pass some particular data
            Customer c1 = new Customer("Anna", "anna@gmail.com", new DateTime(1992, 11, 28), DateTime.Now);

            c1.CreateAccount(); //creating account for  customer c1
            c1.CreateAccount(); //creating another account for  customer c1

            c1.DepositToAccount(100, 0); // deposit to account with index 0 amount of 100

            c1.ListAccounts(); // listing all the accounts of c1
            c1.ListAccount(1); // listing c1 account of the particular index

            c1.Info(); // showing the personal info of the customer c1

        }
    }
}
