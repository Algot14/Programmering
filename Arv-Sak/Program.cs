using System;

namespace Arv_Sak
{
    class Program
    {
        static void Main(string[] args)
        {
            Databas db = new Databas();
            db.Add(new Dvd("Gröt", "Klas"));
            db.Add(new Dvd("Bröd", "Patrik"));
            db.Add(new Dvd("Mjölk", "Kalle"));
            db.Add(new Cd("Fisk", "Julia"));
            db.Add(new Cd("Älg", "Robert"));
            db.Add(new Cd("Potatis", "Karin"));

            db.Skrivut();
        }

       

      

	

	}

       
    
}
