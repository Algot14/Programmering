using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Anställda
{
    class BasOchProvisionanställd : Provisionanställd
    {
        private double fastlön;

        public BasOchProvisionanställd(string namnet, double provisionen, double försäljningen, double lön):base(namnet, provisionen, försäljningen)
        {
            fastlön = lön;
        }

        public override double BeräknaLön()
        {
            return fastlön + provision * försäljning;
        }

        public override string ToString()
        {
            return namn + Environment.NewLine + "BasOchProvisionanställd" + Environment.NewLine + "Provision: " + provision * 100 + "%" + Environment.NewLine + "Försäljning: " + försäljning + Environment.NewLine + "Fast Lön: " + fastlön + Environment.NewLine + "Lön: " + BeräknaLön();
        }

    }
}
