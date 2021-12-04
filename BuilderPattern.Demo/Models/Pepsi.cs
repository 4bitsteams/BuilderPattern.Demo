using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Demo.Models
{
    public class Pepsi : ColdDrink
    {
        public override float Price()
        {
            return 35.0f;
        }

        public override String Name()
        {
            return "Pepsi";
        }
    }
}
