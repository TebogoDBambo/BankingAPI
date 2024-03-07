using System.Security.Principal;
using System;
using Banking.Domain;

namespace Banking.Application
{
    public interface IBankingRepository
    {
        //  - Create a new bank account for a customer, with an initial deposit amount.A
        //  single customer may have multiple bank accounts.
        void CreateCustomerAccount(Customer customer);

        //- Transfer amounts between any two accounts, including those owned by
        //  different customers.
        void TransferAmounts(Account account1, Account account2, decimal amount);

        //- Retrieve balances for a given account.
        decimal GetBalance(Account account);

        //- Retrieve transfer history for a given account.
        List<Account> GetTransferHistory(Account account);

    }
}
