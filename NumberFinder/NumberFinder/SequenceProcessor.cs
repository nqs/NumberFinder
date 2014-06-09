
using NumberFinder.Infrastructure.IO;
using NumberFinder.Infrastructure.Finder;
using System;

namespace NumberFinder
{
    public class SequenceProcessor : ISequenceProcessor
    {
        protected INumberProvider _provider;
        protected INumberFinder _finder;

        public SequenceProcessor(INumberProvider provider, INumberFinder finder)
        {
            _provider = provider;
            _finder = finder;
        }

        public int GetMissingNumber()
        {
            return _finder.FindMissingNumber(_provider.GetNumbers());
        }
    }
}
