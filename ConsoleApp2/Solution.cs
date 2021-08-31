using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Solution
    {
        // konstruktor
        public Solution()
        {
        }
        public void Uppgift_1A()
        {
            Console.WriteLine("Vad heter du?");
            string name = Console.ReadLine();
            Console.WriteLine("Hej " + name + ". Varmt Välkommen");
            Console.WriteLine();
        }

        public void Uppgift_1B()
        {
            Console.WriteLine("Mata in bredd:");
            String bredd = Console.ReadLine();
            Console.WriteLine("Mata in höjd:");
            String höjd = Console.ReadLine();
            double bredd1 = Convert.ToDouble(bredd);
            double höjd1 = Convert.ToDouble(höjd);
            double area = bredd1 * höjd1 / 2;
            Console.WriteLine("arean =");
            Console.WriteLine(area);


        }
        public void Uppgift_2A()
        {
            Console.WriteLine("Gissa mitt favorit tal");
            int tal = Convert.ToInt32(Console.ReadLine());
            if (tal == 3)
            {
                Console.WriteLine("Grattis du gissade rätt!");

            }

            else
            {
                Console.WriteLine("Fel du suger!");
            }



        }
        public void Uppgift_2B()
        {
            Random tärning1 = new Random();
            int antalÖgon = tärning1.Next(1, 7);
            Console.WriteLine("Tärningen visar: " + antalÖgon);
            int antalÖgon2 = tärning1.Next(1, 7);
            Console.WriteLine("Tärningen visar: " + antalÖgon2);
            if (antalÖgon == antalÖgon2)
            {
                Console.WriteLine("Vinst!");
            }

            else
            {
                Console.WriteLine("Förlust!");
            }






        }
        public void Uppgift_3A()
        {
            for (int räknare = 10; räknare > -1; räknare = räknare - 1)
                Console.Write(räknare + ",");
            Console.WriteLine();
        }



        public void Uppgift_4A()
        {
            int räknare = 0;
            while (räknare < 6)
            {
                Console.Write(räknare + ",");
                räknare = räknare + 1;


            }
            Console.WriteLine();
        }
        public void Uppgift_5A()
        {
            String input = "j";
            while (input.Equals("j"))
            {
                Console.WriteLine("Gissa mitt favorital!!");
                int tal = Convert.ToInt32(Console.ReadLine());

                if (tal == 15)
                {
                    Console.WriteLine("Grattis du gissade rätt");
                }

                else
                {
                    Console.WriteLine("Det var fel");
                    Console.WriteLine("Vill du gissa igen j/n");

                }

                input = Console.ReadLine();

            }

            Console.WriteLine("klart!");
            Console.WriteLine();

        }
        public void Uppgift_6A()
        {
            Random tärning1 = new Random();
            int antalÖgon = tärning1.Next(1, 7);
            Console.WriteLine("Tärning 1 visar: " + antalÖgon);
            int antalÖgon2 = tärning1.Next(1, 7);
            Console.WriteLine("Tärning 2 visar: " + antalÖgon2);
            if (antalÖgon + antalÖgon2 == 12)
            {
                Console.WriteLine("Stor Vinst!");
            }

            else if (antalÖgon == antalÖgon2)
            {
                Console.WriteLine("Liten Vinst");
            }

            else
            {
                Console.WriteLine("Förlust");
            }
        }
        public void Uppgift_7A()
        {
            int[] lista = new int[6];
            lista[0] = 3;
            lista[1] = 5;
            lista[2] = 7;
            lista[3] = 9;
            lista[4] = 11;
            lista[5] = 13;


            foreach (int talet in lista)
            {
                Console.WriteLine(talet + ", ");
            }

        }
        public void Uppgift_8B()
        {
            int[] lista = new int[6];
            lista[0] = 3;
            lista[1] = 5;
            lista[2] = 7;
            lista[3] = 9;
            lista[4] = 11;
            lista[5] = 13;

            foreach (int i in lista)
            {
                Console.Write("{0}, ", i + 1);
            }
        }
        public void Uppgift_9A()
        {
            printAgent();
        }
        private void printAgent()
        {
            Console.WriteLine("Välkommen Agent X. Ditt uppdrag är...");
        }
        public void Uppgift_9B()
        {
            Console.WriteLine("Skriv in ett tal:");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal:");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal till:");
            int tal3 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(Addera(tal1 , tal2 , tal3));
        }
        private int Addera(int x, int y, int z)
        {
            return x + y + z; 
        }
        public void Uppgift_10A()
        {
            
            String[] lista = new String[100];
            String input = "j";
            int räknare = 0;
            while (input.Equals("j"))
            {
                Console.WriteLine("Vilken vara vill du lägga till?");
                lista[räknare] = Console.ReadLine();
                räknare = räknare + 1;
                Console.WriteLine("Vill du lägga till något mer j/n?");
                input = Console.ReadLine();          
            }
            foreach (string vara in lista)
            {
                if (vara != null)
                {
                    Console.Write(vara + " ");
                }
                
            }


            

        }
        



    }
    

}


