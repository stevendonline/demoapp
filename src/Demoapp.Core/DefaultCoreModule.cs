using Autofac;
using Demoapp.Core.Interfaces;
using Demoapp.Core.Services;

namespace Demoapp.Core;

public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ToDoItemSearchService>()
            .As<IToDoItemSearchService>().InstancePerLifetimeScope();
    }
}
