using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Kortlek
    {
        private List<Kort> frågor;
        
        public Kortlek()
        {
            frågor = new List<Kort>();
            frågor.Add(new Kort("Vad är 5+5?", "10"));
            frågor.Add(new Kort("Vad heter Sveriges huvudstad?", "Stockholm"));
            frågor.Add(new Kort("Hur många dagar är det på ett år?", "365"));
            frågor.Add(new Kort("Hur många kort är det i en kortlek?", "52"));

        }

        public void Drakort()
        {

        }
    
    
    }
}
