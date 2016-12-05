using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.CS6
{
    public class BankAccount
    {
        public string AccountName;
        public decimal Balance; // non-static - each instance of BankAccount will have its own Balance
        public static decimal InterestRate; // static - all instances of BankAccount share a single InterestRate field
    }
}
