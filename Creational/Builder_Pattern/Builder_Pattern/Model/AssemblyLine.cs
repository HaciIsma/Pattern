using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Model
{
    public class AssemblyLine
    {
        public void Assemble(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeats();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddCondiments();
        }
    }
}
