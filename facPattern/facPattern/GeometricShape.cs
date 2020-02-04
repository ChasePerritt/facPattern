using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 3 February 2020
 * File: GeometricShape.cs
 * Description: This is the interface file for the IGeometricShape interface's classes
 */
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
