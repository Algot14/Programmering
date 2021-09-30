using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Sak
{
    class Cd : Sak
    {
        public String artist;
        public Cd(String titeln, String artisten)
        {
            titel = titeln;
            artist = artisten;
        }

        public override void Skrivut()
        {
            Console.WriteLine("Cd, " + "Namn: " + titel);
            Console.WriteLine("Artist: " + artist);
        }

    }

    
}
