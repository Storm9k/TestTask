﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask
{
    interface ITask <T>
    {
        T Result();

    }
}
