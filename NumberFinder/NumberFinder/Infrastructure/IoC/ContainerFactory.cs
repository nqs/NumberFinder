using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using System.Reflection;

namespace NumberFinder.Infrastructure.IoC
{
    public class ContainerFactory
    {
        public static ContainerBuilder GetContainerBuilder()
        { 
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());
            return builder;
        }
    }

}
