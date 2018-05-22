using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using WpfChat.Common;

namespace WpfChat.Infrastructure.DI
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<UserRepository>()
                .As<IRepository<User>>();

            base.Load(builder);
        }
    }
}
