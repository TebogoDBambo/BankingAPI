using Banking.Application;
using Banking.Domain;

namespace Banking.Infrastructure
{
    public class BankingRepository : IBankingRepository
    {
        private BankingDbContext _bankingDbContext;

        public BankingRepository(BankingDbContext bankingDbContext)
        {
            _bankingDbContext = bankingDbContext;
        }
        public void CreateCustomerAccount(Customer customer)
        {
            _bankingDbContext.Customer.Add(customer);
            _bankingDbContext.SaveChanges();
        }

        public decimal GetBalance(Account account)
        {
          var balance = _bankingDbContext.Account.FirstOrDefault(account).Balance;
            return balance;
        }

        public List<Account> GetTransferHistory(Account account)
        {
            var transferHistory = _bankingDbContext.Account.Where(x => x.AccountNumber == account.AccountNumber).ToList();
            return transferHistory;
        }

        public void TransferAmounts(Account account1, Account account2, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
