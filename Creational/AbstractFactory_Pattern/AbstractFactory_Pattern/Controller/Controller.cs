using AbstractFactory_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_Pattern.Controller
{
    public class Controller
    {
        public void Control()
        {
            var factory = new Factory();
            factory.BenzineVerchile.GetCar().Speed();
        }
    }
}
