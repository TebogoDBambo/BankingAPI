using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain
{
    public class CustomerAccounts
    {
        public long CustomerID { get; set; }
        public long CustomerAccount{ get; set; }
        public DateTime CreationDate { get; set; }
    }
}
