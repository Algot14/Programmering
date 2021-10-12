using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Anställda
{
    abstract class Anställd
    {
        protected String namn;


        public Anställd(String namnet)
        {
            namn = namnet;
        }
        
        public String Namn
        {
            get
            {
                return namn;
            }
            set
            {
                namn = value;
            }
        }

      

        public abstract double BeräknaLön();

        

        
    
    }
}
