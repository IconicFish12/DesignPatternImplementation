﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverProject
{
    internal interface IObserver
    {
        void Update(string productName, int stock);
    }
}
