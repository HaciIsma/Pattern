﻿namespace AbstractFactory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new Controller.Controller();
            controller.Control();
        }
    }
}
