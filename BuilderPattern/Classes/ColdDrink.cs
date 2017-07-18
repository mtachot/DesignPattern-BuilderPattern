using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Classes
{
    public abstract class ColdDrink : IItem
    {
        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
        public abstract string Name();
    }
}
