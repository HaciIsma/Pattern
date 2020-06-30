using AbstractFactory_Pattern.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_Pattern.Model
{
    public class BenzineVerchile : IVerchile
    {
        public ICar GetCar()
        {
            return new BenzineCar();
        }

        public ITruck GetTruck()
        {
            return new BenzineTruck();
        }
    }
}
