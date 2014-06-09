using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NumberFinder.Infrastructure.Configuration;

namespace NumberFinder.Infrastructure.IO
{
    public class FileNumberProvider : INumberProvider
    {
        protected IConfigurationProvider _config;
        public FileNumberProvider(IConfigurationProvider config)
        {
            _config = config;
        }

        public int[] GetNumbers()
        {
            return File.ReadAllLines(_config.InputFileLocation()).Select(line => Convert.ToInt32(line.Trim())).ToArray();
        }
    }
}
