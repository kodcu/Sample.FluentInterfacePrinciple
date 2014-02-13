using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample5
{
    // Fluent Entity Designing
    public class Account
    {
        public int AccountType { get; private set; }
        public int AccountNumber { get; private set; }
        public int AccountSuffix { get; private set; }
        public string CustomerName { get; private set; }

        public Account Create()
        {
            return new Account();
        }

        public Account SetAccountType(int accountType)
        {
            this.AccountType = accountType;
            return this;
        }

        public Account SetAccountNumber(int accountNumber)
        {
            this.AccountNumber = accountNumber;
            return this;
        }

        public Account SetAccountSuffix(int accountSuffix)
        {
            this.AccountSuffix = accountSuffix;
            return this;
        }
        
        public Account SetCustomerName(string customerName)
        {
            this.CustomerName = customerName;
            return this;
        }
    }
}
