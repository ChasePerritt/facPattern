using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facPattern
{
    interface IGeometricShape
    {
        void Draw();
    }

    class GeometricShape : IGeometricShape
    {
        void IGeometricShape.Draw()
        {
            Console.WriteLine("<shape> is drawn.");
        }
    }

    class Line : IGeometricShape
    {
        void IGeometricShape.Draw()
        {
            Console.WriteLine("Line is drawn.");
        }
    }

    class Circle : IGeometricShape
    {
        void IGeometricShape.Draw()
        {
            Console.WriteLine("Circle is drawn.");
        }
    }

    class Rectangle : IGeometricShape
    {
        void IGeometricShape.Draw()
        {
            Console.WriteLine("Rectangle is drawn.");
        }
    }
}
