using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Kort
    {
        private string fråga;
        private string svar;
        

        public Kort(String f, String s)
        {
            fråga = f;
            svar = s;
        }


        
        public void Skrivut()
        {
            Console.WriteLine(fråga);
        }

        public String Svar
        {
            get
            {
                return svar;
            }
        }


    }
}
