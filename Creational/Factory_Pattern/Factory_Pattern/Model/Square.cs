using Factory_Pattern.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern.Model
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine(GetType().Name);
        }
    }
}
