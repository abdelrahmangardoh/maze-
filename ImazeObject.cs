﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    public interface ImazeObject
    {
        char icon { get;  }
        bool isolidated { get;  }

    }
}
