using AbstractFactory_Pattern.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_Pattern.Model
{
    public class ElectricTruck : ITruck
    {
        public void Strong()
        {
            Console.WriteLine("I am very strong");
        }
    }
}
