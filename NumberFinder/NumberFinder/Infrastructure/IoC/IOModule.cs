using Autofac;
using NumberFinder.Infrastructure.IO;

namespace NumberFinder.Infrastructure.IoC
{
    public class IOModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FileNumberProvider>().As<INumberProvider>();
        }
    }
}
