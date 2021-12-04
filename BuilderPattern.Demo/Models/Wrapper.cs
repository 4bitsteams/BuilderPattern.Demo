using BuilderPattern.Demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Demo.Models
{
    public class Wrapper : Packing
    {
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
