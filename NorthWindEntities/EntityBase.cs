﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindEntities
{
    public abstract class EntityBase
    {
        public abstract string IdentityColumn { get; }
    }
}