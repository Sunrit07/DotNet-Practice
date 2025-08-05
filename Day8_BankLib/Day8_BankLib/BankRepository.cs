using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_BankLib
{
    public class BankRepository : IBankRepository
    {
        private List<SBAccount> accounts = new List<SBAccount>();
        private List<SBTransaction> transactions = new List<SBTransaction>();
        public void NewAccount(SBAccount acc)
        {
            if (accounts.Any(a => a.AccountNumber == acc.AccountNumber))
                throw new Exception("Account number already exists.");

            accounts.Add(acc);
        }

        public List<SBAccount> GetAllAccounts()
        {
            return accounts;
        }

        public SBAccount GetAccountDetails(int accno)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accno);
            if (account == null)
                throw new Exception("Account not found.");
            return account;
        }

        public void DepositAmount(int accno, decimal amt)
        {
            var account = GetAccountDetails(accno);
            account.CurrentBalance += amt;

            var transaction = new SBTransaction
            {
                TransactionId = transactions.Count + 1,
                TransactionDate = DateTime.Now,
                AccountNumber = accno,
                Amount = amt,
                TransactionType = "Deposit"
            };
            transactions.Add(transaction);
        }

        public void WithdrawAmount(int accno, decimal amt)
        {
            var account = GetAccountDetails(accno);
            if (account.CurrentBalance < amt)
                throw new Exception("Insufficient balance.");

            account.CurrentBalance -= amt;

            var transaction = new SBTransaction
            {
                TransactionId = transactions.Count + 1,
                TransactionDate = DateTime.Now,
                AccountNumber = accno,
                Amount = amt,
                TransactionType = "Withdraw"
            };
            transactions.Add(transaction);
        }

        public List<SBTransaction> GetTransactions(int accno)
        {
            return transactions.Where(t => t.AccountNumber == accno).ToList();
        }
    }
}
