using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application
{
    internal interface IBankingService
    {
        //  - Create a new bank account for a customer, with an initial deposit amount.A
        //  single customer may have multiple bank accounts.
        void CreateCustomerAccount(Customer customer);

        //- Transfer amounts between any two accounts, including those owned by
        //  different customers.
        void TransferAmounts(Account account1, Account account2, decimal amount);

        //- Retrieve balances for a given account.
        long GetBalance(Account account);

        //- Retrieve transfer history for a given account.
        List<string> GetTransferHistory(Account account);
    }
}
