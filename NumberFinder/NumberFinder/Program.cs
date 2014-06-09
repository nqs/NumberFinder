using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using NumberFinder.Infrastructure.IoC;
namespace NumberFinder
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var container = ContainerFactory.GetContainerBuilder().Build())
            {
                var sequenceProcessor = container.Resolve<ISequenceProcessor>();

                var missingNumber = sequenceProcessor.GetMissingNumber();

                Console.WriteLine(String.Format("Missing Number: {0}", missingNumber));
                Console.ReadLine();
            }
        }
    }
}
