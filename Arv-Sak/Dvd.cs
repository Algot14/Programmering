using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Sak
{
    class Dvd : Sak
    {
        protected String regisör;


        public Dvd(String titeln, String regisören)
        {
            titel = titeln;
            regisör = regisören;
        }

        public override void Skrivut()
        {
            Console.WriteLine("Dvd, " + "Namn: " + titel);
            Console.WriteLine("Regisören: " + regisör);
        }




    }


}
