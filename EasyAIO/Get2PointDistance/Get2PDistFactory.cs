﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyAIO
{
    internal class Get2PDistFactory : AbstractFactory
    {
        public override BaseEvent CreateEvent(Task t)
        {
            return new Get2PDistEvent(t);
        }
    }
}
