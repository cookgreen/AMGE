﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMOFGameEngine.Game.Traits
{
    /// <summary>
    /// Can be destroyed
    /// </summary>
    interface IDestroyable
    {
        void Destroyed();
    }
}