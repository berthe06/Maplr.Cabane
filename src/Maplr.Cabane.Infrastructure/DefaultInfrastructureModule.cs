﻿using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Maplr.Cabane.Core.Interfaces;
using Maplr.Cabane.Core.Interfaces.ICabaneDao;
using Maplr.Cabane.Core.ProjectAggregate;
using Maplr.Cabane.Infrastructure.Data;
using Maplr.Cabane.Infrastructure.Data.Dao;
using Maplr.Cabane.SharedKernel.Interfaces;
using MediatR;
using MediatR.Pipeline;
using Module = Autofac.Module;

namespace Maplr.Cabane.Infrastructure;

public class DefaultInfrastructureModule : Module
{
    private readonly bool _isDevelopment = false;
    private readonly List<Assembly> _assemblies = new List<Assembly>();

    public DefaultInfrastructureModule(bool isDevelopment, Assembly callingAssembly = null)
    {
        /*_isDevelopment = isDevelopment;
        var coreAssembly = Assembly.GetAssembly(typeof(SucreDao)); // TODO: Replace "Project" with any type from your Core project


        var infrastructureAssembly = Assembly.GetAssembly(typeof(StartupSetup));
        _assemblies.Add(coreAssembly);
        _assemblies.Add(infrastructureAssembly);
        if (callingAssembly != null)
        {
            _assemblies.Add(callingAssembly);
        }*/
    }
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ProduitDao>().As<IProduitDao>().InstancePerDependency();
        builder.RegisterType<CommandeDao>().As<ICommandeDao>().InstancePerDependency();



    }


    /*protected override void Load(ContainerBuilder builder)
    {
        if (_isDevelopment)
        {
            RegisterDevelopmentOnlyDependencies(builder);
        }
        else
        {
            RegisterProductionOnlyDependencies(builder);
        }
        RegisterCommonDependencies(builder);
    }*/

    private void RegisterCommonDependencies(ContainerBuilder builder)
    {
        builder.RegisterGeneric(typeof(RepositoryAsync<>))
            .As(typeof(IRepository<>))
            .As(typeof(IReadRepository<>))
            .InstancePerLifetimeScope();

        builder
            .RegisterType<Mediator>()
            .As<IMediator>()
            .InstancePerLifetimeScope();

        builder.Register<ServiceFactory>(context =>
        {
            var c = context.Resolve<IComponentContext>();
            return t => c.Resolve(t);
        });

        var mediatrOpenTypes = new[]
        {
                typeof(IRequestHandler<,>),
                typeof(IRequestExceptionHandler<,,>),
                typeof(IRequestExceptionAction<,>),
                typeof(INotificationHandler<>),
            };

        foreach (var mediatrOpenType in mediatrOpenTypes)
        {
            builder
            .RegisterAssemblyTypes(_assemblies.ToArray())
            .AsClosedTypesOf(mediatrOpenType)
            .AsImplementedInterfaces();
        }

        builder.RegisterType<EmailSender>().As<IEmailSender>()
            .InstancePerLifetimeScope();
    }

    private void RegisterDevelopmentOnlyDependencies(ContainerBuilder builder)
    {
        // TODO: Add development only services
    }

    private void RegisterProductionOnlyDependencies(ContainerBuilder builder)
    {
        // TODO: Add production only services
    }

}
