using Factory_Pattern.Model;
using Factory_Pattern.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Controller
{
    public class Controller
    {
        public void Control()
        {
            Factory factory = new Factory();
            IShape shape = factory.GetShape(ShapeType.Circle);
            shape.Draw();
        }
    }
}
