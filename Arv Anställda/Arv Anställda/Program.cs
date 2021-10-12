using System;

namespace Arv_Anställda
{
    class Program 
    {
        static void Main(string[] args)
        {
            Test ad = new Test();
            ad.Add(new Fastanställd("Per", 25000));
            ad.Add(new Timanställd("Åke", 150, 45));
            ad.Add(new Provisionanställd("Sandra", 0.05, 300000));
            ad.Add(new BasOchProvisionanställd("Linda", 0.07, 500000, 20000));

            ad.Run();

        }
    }
}
