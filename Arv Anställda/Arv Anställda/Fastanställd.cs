using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Anställda
{
    class Fastanställd : Anställd 
    {
        private double månadslön;

        public Fastanställd(string namnet, double lön):base(namnet)
        {
            månadslön = lön;
        }

       

        public override double BeräknaLön()
        {
            return månadslön;
        }

        public override string ToString()
        {
            return namn + Environment.NewLine + "Fastanställd" + Environment.NewLine + "Lön: " + BeräknaLön();
        }

    }
}
