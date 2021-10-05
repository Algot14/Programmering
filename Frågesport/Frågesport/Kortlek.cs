using System;
using System.Collections.Generic;
using System.Text;

namespace Frågesport
{
    class Kortlek
    {
        private List<ModerKort> frågor;
        
        public Kortlek()
        {
            frågor = new List<ModerKort>();
            frågor.Add(new Kort("Vad är 5+5?", "10"));
            frågor.Add(new Kort("Vad heter Sveriges huvudstad?", "Stockholm"));
            frågor.Add(new Kort("Hur många dagar är det på ett år?", "365"));
            frågor.Add(new Kort("Hur många kort är det i en kortlek?", "52"));
            frågor.Add(new Flersvar("Hur många ben har en kossa", "2", "3","4","4"));
            frågor.Add(new Flersvar("Vad heter USA's huvudstad?", "New York", "Washington DC", "Texas", "Washington DC"));
            frågor.Add(new Flersvar("Hur många gruskorn finns det på jorden?", "10", "46", "3", "46"));
        }

        public ModerKort Drakort()
        {
            int lastIndex = frågor.Count - 1;
            ModerKort kort = frågor[lastIndex];
            frågor.RemoveAt(lastIndex);
            return kort;
        }

        public bool HasCards()
        {
            return frågor.Count > 0;
        }
                                                                                                 
    
    }
}
