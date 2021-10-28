using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class BankAccount
    {
        private string accountNumber;
        private string pin;
        private int balance;
        private List<Transfer> successfullTransfers;

        public BankAccount(string accountNumber, string pin)
        {

        }

        public BankAccount(string accountNumber, string pin, int balance)
        {

        }

        public string AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }
        }

        public bool Transfer(Transfer transfer)
        {

        }

        public bool ValidatePin(string pin)
        {

        }

        public List<Transfer> GetTransfers()
        {

        }
    
    }
}
