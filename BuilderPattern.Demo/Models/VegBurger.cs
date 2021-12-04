using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Demo.Models
{
    public class VegBurger : Burger
    {

        public override float Price()
        {
            return 25.0f;
        }

        public override String Name()
        {
            return "Veg Burger";
        }

    }
}
