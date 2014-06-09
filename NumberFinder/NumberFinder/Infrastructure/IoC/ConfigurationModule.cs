using Autofac;
using NumberFinder.Infrastructure.Configuration;

namespace NumberFinder.Infrastructure.IoC
{
    public class ConfigurationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ConfigurationProvider>().As<IConfigurationProvider>();
        }
    }
}
