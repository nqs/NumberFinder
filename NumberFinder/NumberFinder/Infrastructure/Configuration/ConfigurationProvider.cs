using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberFinder.Infrastructure.Configuration
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        public string InputFileLocation()
        {
            return "InputSequence.txt";
        }
    }
}
