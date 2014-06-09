using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFinder.Infrastructure.IO
{
    public interface INumberProvider
    {
        int[] GetNumbers();
    }
}
