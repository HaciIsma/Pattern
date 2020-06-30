using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Model
{
    public abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        public Sandwich Sandwich
        {
            get { return sandwich; }
        }

        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }
}
