using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Flersvar : ModerKort
    {
        private List<String> flersvar;
        private string rättsvar;

        public Flersvar(String f, List<String> s, String rs) : base(f)
        {

            flersvar = s;
            rättsvar = rs;
        }

        public override String GetSvar()
        {
            return rättsvar;
            
        }

        public override void Skrivut()
        {
            Console.WriteLine(fråga);
            foreach (String alternativ in flersvar)
            {
                Console.WriteLine(alternativ);
            }
        }

    }
}
