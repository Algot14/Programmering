using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            Kortlek frågor = new Kortlek();



            Console.WriteLine("Vill du delta i Algot's frågesport? y/n");
            String svar;
            svar = Console.ReadLine();
            if (svar == "y")
            {
                while (frågor.HasCards())
                {

                    
                    
                    ModerKort mittKort = frågor.Drakort();
                    mittKort.Skrivut();

                    Console.WriteLine("Svar: ");
                    String svar2;
                    svar2 = Console.ReadLine();
                    if (svar2 == mittKort.GetSvar())
                    {
                        Console.WriteLine("Du gissade rätt, grattis!");
                    }

                    else
                    {
                        Console.WriteLine("Du gissade fel!");
                        Console.WriteLine("Rätt svar är: " + mittKort.GetSvar());
                    }








                }
            }
        }
    }
}