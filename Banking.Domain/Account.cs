using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain
{
    public class Account
    {
        public long AccountNumber { get; set; }
        public Decimal Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime TransferDate { get; set; } = DateTime.Now;
    }
}
