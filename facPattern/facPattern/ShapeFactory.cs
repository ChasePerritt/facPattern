using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Name: Chase Perritt
 * Date: 3 February 2020
 * File: GeometricShape.cs
 * Description: This is the ShapeFactory file that returns the type of shape to the main driver.
 */
namespace facPattern
{
    class ShapeFactory
    {
        public IGeometricShape GetShape(ShapeType type)
        {
            switch (type)
            {
                default:
                    return null;                // Non-Implemented Shapes are Returned as Null
                case ShapeType.Line:
                    return new Line();
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Rectangle:
                    return new Rectangle();
            }
        }
    }

    enum ShapeType
    {
        Line,
        Circle,
        Rectangle,
        Triangle
    }
}
