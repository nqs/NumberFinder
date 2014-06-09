using Autofac;
using NumberFinder.Infrastructure.Finder;

namespace NumberFinder.Infrastructure.IoC
{
    public class SequenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SequenceProcessor>().As<ISequenceProcessor>();
        }
    }
}
