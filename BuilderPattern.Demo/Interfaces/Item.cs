using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Demo.Interfaces
{
    public interface Item
    {
        public String Name();
        public Packing Packing();
        public float Price();
    }
}
