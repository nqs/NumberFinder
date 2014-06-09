﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFinder.Infrastructure.Finder
{
    public interface INumberFinder
    {
        int FindMissingNumber(int[] sequence);
    }
}
