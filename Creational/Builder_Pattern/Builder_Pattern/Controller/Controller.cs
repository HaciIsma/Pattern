using Builder_Pattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Controller
{
    public class Controller
    {
        public void Control()
        {
            SandwichBuilder builder;

            var shop = new AssemblyLine();
            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Sandwich.Show();
        }
    }
}
