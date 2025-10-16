using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Documents
{
    public class BankAccount
    {
        private static int s_accountNumberSeed = 1234567890;

        private static decimal _minimumBalance;

        private readonly List<Transaction> _allTransactions = new List<Transaction>();

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(var item in _allTransactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0)
        {
        }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            if (initialBalance <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(initialBalance),
                    initialBalance,
                    "Initial balance must be positive.");
            }

            Number = s_accountNumberSeed.ToString();
            s_accountNumberSeed++;

            Owner = name;
            _minimumBalance = minimumBalance; // Yeni alan burada ayarlandı.
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        public void MakeDeposit(decimal amount , DateTime date , string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount));
            }
            var deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            CheckWithdrawalLimit(amount);

            var withdrawal = new Transaction(-amount, date, note);
            _allTransactions.Add(withdrawal);
        }

        protected virtual void CheckWithdrawalLimit(decimal amount)
        {
            if (Balance - amount < _minimumBalance)
            {
                throw new InvalidOperationException($"Not sufficient funds for this withdrawal. Minimum balance limit is: {_minimumBalance}");
            }
        }

        public virtual void PerformMonthEndTransactions()
        {

        }

        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in _allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }
            return report.ToString();
        }

    }
}
