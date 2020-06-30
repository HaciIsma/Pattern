using AbstractFactory_Pattern.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_Pattern.Model
{
    public class ElectricVerchile : IVerchile
    {
        public ICar GetCar()
        {
            return new ElectricCar();
        }

        public ITruck GetTruck()
        {
            return new ElectricTruck();
        }
    }
}
