using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Anställda
{
    class Timanställd : Anställd
    {
        private double timlön;
        private double arbetadeTimmar;

        public Timanställd(string namnet, double timlönen, double timmar) : base(namnet)
        {
            timlön = timlönen;
            arbetadeTimmar = timmar;
        }

        public override double BeräknaLön()
        {
            return timlön * arbetadeTimmar; 
        }

        public override string ToString()
        {
            return namn + Environment.NewLine + "Timmanställd" + Environment.NewLine + "Timmlön: " + timlön + Environment.NewLine + "Arbetade Timmar: " + arbetadeTimmar + Environment.NewLine + "Lön: " + BeräknaLön();
        }

    }
}
