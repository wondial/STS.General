﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace STS.General.Data
{
    public interface IToObjects<T> : ITransformer<T, object[]>
    {
    }
}
