using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    abstract class ModerKort
    {
        protected string fråga;

        public ModerKort(String f)
        {
            fråga = f;
        }

        public abstract void Skrivut();
        public abstract String GetSvar();
    
    
    }
}
