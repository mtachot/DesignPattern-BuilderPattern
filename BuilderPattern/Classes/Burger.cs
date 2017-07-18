using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Classes.Abstract_classes
{
    public abstract class Burger : IItem
    {
        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
        public abstract string Name();
    }
}
