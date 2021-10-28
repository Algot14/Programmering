using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Bank
    {
        private Dictionary<String, BankAccount> accounts;
        private AccountNrGenerator accountNrGenerator;
        private List<Transfer> failingTransfers;

        public Bank()
        {

        }

        public string AddAccount(string pin)
        {

        }

        public string AddAccount(string pin, int balance)
        {

        }

        public string GetBalance(string AccountNr, string pin)
        {

        }

        public bool Transfer(Transfer transfer, string pin)
        {

        }

        public List<Transfer> GetTransfers(string AccountNr, string pin)
        {

        }

    }
}
