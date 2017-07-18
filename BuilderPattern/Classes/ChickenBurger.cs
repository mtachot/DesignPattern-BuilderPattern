﻿using BuilderPattern.Classes.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Classes
{
    public class ChickenBurger : Burger
    {
        public override float Price()
        {
            return 50.5f;
        }

        public override string Name()
        {
            return "Chicken Burger";
        }
    }
}
