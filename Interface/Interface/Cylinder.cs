using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Cylinder : Shape3D
    {
        public double radius;
        public double height;

        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }

        public double GetArea()
        {
            return  Math.PI * radius * radius * 2 + 2 * Math.PI * radius * height;
        }

        public double GetVolume()
        {
            return radius * radius * Math.PI * height;
        }

        public override string ToString()
        {
            return "Cylinder" + Environment.NewLine + "Radius: " + radius + Environment.NewLine + "Height: " + height + Environment.NewLine + "Area: " + GetArea() + Environment.NewLine + "Volume: " + GetVolume();
        }


    }
}
