using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Sphere : Shape3D 
    {
        private double radius;

        public Sphere(double r)
        {
            radius = r;
        }
     
        public double GetArea()
        {
             return 4 * Math.PI * radius * radius;
        }
     public double GetVolume()
        {
            return 4 * Math.PI * radius * radius * radius / 3;
        }

        public override string ToString()
        {
            return "Sphere" + Environment.NewLine + "Radius: " + radius + Environment.NewLine + GetArea() + Environment.NewLine + "Volume: " + GetVolume();
        }


    }
}
