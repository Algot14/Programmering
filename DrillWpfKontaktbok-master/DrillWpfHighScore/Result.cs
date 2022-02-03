using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DrillWpfHighScore
{
    class Result : IComparable<Result>
    {
        private int nummer;
        private string name;
        private string efternamn;
        // lägg till name

        // lägg till konstruktor

        public Result(int nummer, string namn, string efter)
        {
            this.nummer = nummer;
            this.name = namn;
            this.efternamn = efter;
        }

        // property
        public int Nummer
        {
            get
            {
                return nummer;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Efternamn
        {
            get
            {
                return efternamn;
            }
        }
        // lägg till ToString() eller property Name

        
        public int CompareTo([AllowNull] Result other)
        {
            // Metoden CompareTo behövs för att implementera interfacet IComparable.
            // Denna metod används sedan när listan sorteras.
            // Sorteras på score. Störst kommer först.
            // Metoden returnerar -1 om detta (this) objektet är större än det andra objektet (other)
            // och annars returneras 1
            // null-värde hamnar sist i listan. Vi bör dock inte ha null-värden i listan.

            if (other == null)
            {
                // this is first
                return -1;
            }
            else if (Nummer > other.Nummer)
            {
                // this is first
                return -1;
            }
            else
            {
                // other is first
                return 1;
            }                
        }
    }
}
