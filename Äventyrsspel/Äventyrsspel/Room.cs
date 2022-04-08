using System;
using System.Collections.Generic;
using System.Text;

namespace Äventyrsspel
{
    class Room
    {
        private string beskrivning;
        private Room norr;
        private Room söder;
        private Room väster;
        private Room öster;

        public Room(string besk)
        {
            beskrivning = besk;
        }

        public Room Norr
        {
            get
            {
                return norr;
            }
            set
            {
                norr = value;
            }
        }

        public Room Söder
        {
            get
            {
                return söder;
            }
            set
            {
                söder = value;
            }
        }

        public Room Väster
        {
            get
            {
                return väster;
            }
            set
            {
                väster = value;
            }
        }

        public Room Öster
        {
            get
            {
                return öster;
            }
            set
            {
                öster = value;
            }
        }

        public string Beskrivning
        {
            get
            {
                return beskrivning;
            }        
        }







    }
}
