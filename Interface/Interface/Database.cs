using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Database
    {
        public List<Shape3D> shapes = new List<Shape3D>();

        public void AddShape(Shape3D shape)
        {
            shapes.Add(shape);
        }

        public void Print()
        {
            foreach (Shape3D shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    
    }

    
}
