using BuilderPattern.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Demo.Models
{
    public abstract class ColdDrink : Item
    {
        public abstract string Name();

        public Packing Packing()
        {
            return new Bottle();
        }
        public abstract float Price();
    }
}
