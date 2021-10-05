using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Flersvar : ModerKort
    {
        private string svar1;
        private string svar2;
        private string svar3;
        private string rättsvar;

        public Flersvar(String f, String s1, String s2, String s3, String rs):base(f)
        {
            
            svar1 = s1;
            svar2 = s2;
            svar3 = s3;
            rättsvar = rs;
        }

        public override String GetSvar()
        {
            return rättsvar;
            
        }

        public override void Skrivut()
        {
            Console.WriteLine(fråga);
            Console.WriteLine("Välj mellan: " + svar1 + ", " + svar2 + ", " + svar3);
        }

    }
}
