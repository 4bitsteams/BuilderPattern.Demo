using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Demo.Models
{
    public class ChickenBurger : Burger
    {
        public override float Price()
        {
            return 50.5f;
        }

        public override String Name()
        {
            return "Chicken Burger";
        }
    }
}
