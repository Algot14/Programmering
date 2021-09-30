using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Sak
{
    class Databas 
    {
        private List<Sak> saker;

        public Databas()
        {
            saker = new List<Sak>();
        }

        public void Add(Sak enSak)
        {
            saker.Add(enSak);
        }

        public void Skrivut()
        {
            foreach (Sak saken in saker)
            {
                saken.Skrivut();
            }
        }

        
    
    
    
    }

    

}
