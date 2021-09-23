using System;
using System.Collections.Generic;
using System.Text;

namespace zoo
{
    class Cat
    {
        private int age;
    
     public Cat(int i)
        {
            age = i;
        }

       
       
        public void Act()
        {
            for (int i = 0; i < age; ++i)
            {
                Console.Write("Mjau, ");
                
            }
                
        }
    
    }
}
