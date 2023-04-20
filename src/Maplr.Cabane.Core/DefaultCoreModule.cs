using Autofac;
using Maplr.Cabane.Core.Interfaces;
using Maplr.Cabane.Core.Interfaces.CabaneManagment;
using Maplr.Cabane.Core.Services;
using Maplr.Cabane.Core.Services.CabaneMagement;

namespace Maplr.Cabane.Core;

public class DefaultCoreModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ToDoItemSearchService>()
            .As<IToDoItemSearchService>().InstancePerLifetimeScope();
        builder.RegisterType<SucreService>().As<ISucreService>().InstancePerLifetimeScope();
    }
}
