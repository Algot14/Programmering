using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Anställda
{
    class Provisionanställd : Anställd
    {
        protected double provision;
        protected double försäljning;

        public Provisionanställd(String namnet, double provisionen, double försäljningen):base(namnet)
        {
            provision = provisionen;
            försäljning = försäljningen;
        }

        public override double BeräknaLön()
        {
            return provision * försäljning;
        }

        public override string ToString()
        {
            return namn + Environment.NewLine + "Provisionanställd" + Environment.NewLine + "Provision: " + provision * 100 + "%" + Environment.NewLine + "Försäljning: " + försäljning + Environment.NewLine + "Lön: " + BeräknaLön();
        }




    }
}
