using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Anställda
{
    class UserInterface
    {
        private List<Anställd> anställda;

        public UserInterface()
        {
            anställda = new List<Anställd>();
        }

        public void Add(Anställd enAnställd)
        {
            anställda.Add(enAnställd);
        }
        public void Run()
        {
            Console.WriteLine("1. Lägg till ny anställd");
            Console.WriteLine("2. Skriv ut uppgifter om alla anställda");
            Console.WriteLine("3. Skriv ut namn på alla anställda");
            Console.WriteLine("4. Ändra på uppgifter om en anställd");
            Console.WriteLine("a. Avsluta");
            String svar;
            svar = Console.ReadLine();

            if (svar == "1")
            {
                Console.WriteLine("1. Fastanställd");
                Console.WriteLine("2. Timanställd");
                //Console.WriteLine("3. Timanställd");
                //Console.WriteLine("4. BasOchProvisionanställd");
                String svar2;
                svar2 = Console.ReadLine();
                if (svar2 == "1")
                {
                    Console.WriteLine("Vad heter den anställda?");
                    String namn;
                    namn = Console.ReadLine();
                    Console.WriteLine("Hur mycket tjänar den anställda per månad?");
                    String månadslön;
                    månadslön = Console.ReadLine();
                    double månadslön2 = Convert.ToDouble(månadslön);
                    anställda.Add(new Fastanställd(namn, månadslön2));
                    Console.WriteLine(namn + " har lagts till i listan!");
                    
                }
                else if (svar2 == "2")
                {
                    Console.WriteLine("Vad heter den anställda?");
                    String namn;
                    namn = Console.ReadLine();
                    Console.WriteLine("Hur mcyket tjänar den anställda i timmen?");
                    String timlön;
                    timlön = Console.ReadLine();
                    double timlön2 = Convert.ToDouble(timlön);
                    Console.WriteLine("Hur många timmar i veckan jobbar den anställda?");
                    String arbetadeTimmar;
                    arbetadeTimmar = Console.ReadLine();
                    double arbetadeTimmar2 = Convert.ToDouble(arbetadeTimmar);
                    anställda.Add(new Timanställd(namn, timlön2, arbetadeTimmar2));
                }
            else if (svar == "2")
            {
                  SkrivutAlla();     
            }
            else if (svar == "3")
            {
                foreach (Anställd workers in anställda)
                {
                    Console.WriteLine(workers.Namn);
                }
            }
            else if (svar == "4")
            {
                Console.WriteLine("Vad har personen för typ av anställning?");
                Console.WriteLine("1. Fastanställd");
                Console.WriteLine("2. Timanställd");
                    string svar3;
                    svar3 = Console.ReadLine();
                    if(svar3 == "1")
                    {
                        Console.WriteLine("Välj en anställd");
                        foreach (Anställd workers in anställda)
                        {
                            if (workers.GetType().Name == "Fastanställd")
                            {
                                Console.WriteLine(workers.Namn);

                            }
                        }
                        String svar5;
                        svar5 = Console.ReadLine();
                        foreach (Anställd workers in anställda)
                        {
                            if (svar5 == workers.Namn)
                            {
                                Console.WriteLine("Vad vill du ändra?");
                                Console.WriteLine("1. Namn");
                                Console.WriteLine("2. Månadslön");
                                string svar6;
                                svar6 = Console.ReadLine();
                                if (svar6 == "1")
                                {
                                    Console.WriteLine("Skriv in ditt nya namn: ");
                                    string nyttNamn;
                                    nyttNamn = Console.ReadLine();
                                    workers.Namn = nyttNamn;
                                }
                                else if (svar6 == "2")
                                {
                                    Console.WriteLine("Skriv in den nya månadslönen: ");
                                    string nylön;
                                    nylön = Console.ReadLine();


                                }

                            }
                        }
                    
                    } 





            }
            



                





            }
        }
        public void SkrivutAlla()
        {
            foreach (Anställd workers in anställda)
            {
                Console.WriteLine(workers.ToString());

            }
        }



    }
}
