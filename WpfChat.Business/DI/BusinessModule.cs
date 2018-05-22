using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace WpfChat.Business.DI
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<LoginBusiness>()
                .As<ILoginBusiness>();
            base.Load(builder); 
        }
    }
}
