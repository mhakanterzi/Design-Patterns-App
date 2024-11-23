﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.Prototype
{
    public interface PrototypeInterface
    {
        PrototypeInterface GetClone();
    }
}
