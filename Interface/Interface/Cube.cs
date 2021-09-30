using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Cube : Shape3D
    {
        public double length;

        public Cube(double l)
        {
            length = l;
        }

        public double GetArea()
        {
            return 6 * length * length;
        }

        public double GetVolume()
        {
            return length * length * length;
        }

        public override string ToString()
        {
            return "Cube" + Environment.NewLine + "Length of side: " + length + Environment.NewLine + "Area: " + GetArea() + Environment.NewLine + "Volume: " + GetVolume();
        }


    }
}
