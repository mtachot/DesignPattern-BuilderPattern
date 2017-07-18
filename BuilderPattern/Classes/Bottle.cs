using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Classes
{
    public class Bottle : IPacking
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}
