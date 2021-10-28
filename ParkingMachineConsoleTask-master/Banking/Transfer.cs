using System;

namespace Banking
{
    public class Transfer
    {
        private string fromAccountNr;
        private string toAccountNr;
        private int amount; 

        public Transfer(string fromAccountNr, string toAccountNr, int amount)
        {

        }

        public string FromAccountNr
        {
            get
            {
                return fromAccountNr;
            }
        }

        public string ToAccountNr
        {
            get
            {
                return toAccountNr;
            }
        }

        public int Amount
        {
            get
            {
                return amount;
            }
        }

       
    
    }
}
