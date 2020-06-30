using Singleton_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern.Controller
{
    public class Controller
    {
        public void Control()
        {
            Singleton.GetSingleton.Smth();
        }
    }
}
