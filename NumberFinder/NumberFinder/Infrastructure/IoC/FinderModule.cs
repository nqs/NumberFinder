using Autofac;
using NumberFinder.Infrastructure.Finder;

namespace NumberFinder.Infrastructure.IoC
{
    public class FinderModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<NaiveNumberFinder>().As<INumberFinder>();
        }
    }
}
