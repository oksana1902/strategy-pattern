﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class FlyNoWay: IFlyBehavior
    {
        public string Fly()
        {
            return "I'm can't fly";
        }
    }
}
