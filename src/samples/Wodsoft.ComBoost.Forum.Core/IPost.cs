﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wodsoft.ComBoost.Data.Entity;

namespace Wodsoft.ComBoost.Forum.Core
{
    [EntityInterface]
    public interface IPost : IEntity
    {
        IMember Member { get; set; }

        string Content { get; set; }

        IThread Thread { get; set; }
    }
}
