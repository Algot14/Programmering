using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_Anställda
{
    class Test
    {
        private List<Anställd> anställda;

        public Test()
        {
            anställda = new List<Anställd>();
        }

        public void Add(Anställd enAnställd)
        {
            anställda.Add(enAnställd);
        }

        public void Run()
        {
            foreach (Anställd workers in anställda)
            {
                Console.WriteLine(workers.ToString());
                
            }
        }



    }
}
