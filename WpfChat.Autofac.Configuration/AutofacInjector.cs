using Autofac;
using System;
using WpfChat.Business;
using WpfChat.Business.DI;
using WpfChat.Infrastructure.DI;

namespace WpfChat.Autofac.Configuration
{
    public static class AutofacInjector
    {
        private static readonly ContainerBuilder _builder;
        private static IContainer container;
        static AutofacInjector()
        {
            _builder = new ContainerBuilder();
        }
        public static void Builder()
        {
            _builder.RegisterModule(new BusinessModule());
            _builder.RegisterModule(new InfrastructureModule());

            container = _builder.Build();
        }

        public static ILoginBusiness ResolveLoginBusiness()
        {
            return (ILoginBusiness)container.Resolve(typeof(ILoginBusiness));
        }
    }
}
