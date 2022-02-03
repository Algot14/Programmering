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
        }

        public Room Söder
        {
            get
            {
                return söder;
            }
        }

        public Room Väster
        {
            get
            {
                return väster;
            }
        }

        public Room Öster
        {
            get
            {
                return öster;
            }
        }







    }
}
