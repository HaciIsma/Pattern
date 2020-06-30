using AbstractFactory_Pattern.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_Pattern.Model
{
    public class BenzineCar : ICar
    {
        public void Speed()
        {
            Console.WriteLine("I am very speedly");
        }
    }
}
