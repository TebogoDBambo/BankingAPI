using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Application
{
    public class BankingService : IBankingService
    {
        private IBankingRepository _bankingRepository;

        public BankingService(IBankingRepository bankingRepository)
        { 
            _bankingRepository = bankingRepository;
        
        }

        public void CreateCustomerAccount(Customer customer)
        {
            _bankingRepository.CreateCustomerAccount(customer);

        }

        public decimal GetBalance(Account account)
        {
          return _bankingRepository.GetBalance(account); 
        }

        public List<Account> GetTransferHistory(Account account)
        {
           return _bankingRepository.GetTransferHistory(account);
        }

        public void TransferAmounts(Account account1, Account account2, decimal amount)
        {
           _bankingRepository.TransferAmounts(account1, account2, amount);
        }
    }
}
