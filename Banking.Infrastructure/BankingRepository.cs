using Banking.Application;
using Banking.Domain;

namespace Banking.Infrastructure
{
    public class BankingRepository : IBankingRepository
    {
        public void CreateCustomerAccount(Customer customer)
        {
            throw new NotImplementedException();
        }

        public long GetBalance(Account account)
        {
            throw new NotImplementedException();
        }

        public List<string> GetTransferHistory(Account account)
        {
            throw new NotImplementedException();
        }

        public void TransferAmounts(Account account1, Account account2, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
