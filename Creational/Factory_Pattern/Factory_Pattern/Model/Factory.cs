using Factory_Pattern.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Model
{
    public enum ShapeType
    {
        Circle,
        Square
    }
    public class Factory
    {
        public IShape GetShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Square:
                    return new Square();
            }
            return null;
        }
    }
}
