﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawer.Modles
{
    [Serializable]
    class Wall : Drawer
    {
        public Wall()
        {
            color = ConsoleColor.White;
            sign = '#';
        }
        
    }
}
