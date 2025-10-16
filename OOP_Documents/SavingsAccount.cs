using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Documents
{
    public class SavingsAccount:BankAccount
    {
        public static readonly decimal InterestRate = 0.02m;

        public SavingsAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        public override void PerformMonthEndTransactions()
        {
            decimal interestAmount = Balance * InterestRate;

            MakeDeposit(interestAmount, DateTime.Now, "Ay Sonu Faiz Kazanımı");
        }
    }
}
