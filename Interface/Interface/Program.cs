using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            db.AddShape(new Cube(3));
            db.AddShape(new Cylinder(4, 7));
            db.AddShape(new Sphere(3));

            db.Print();
        }
    }
}
