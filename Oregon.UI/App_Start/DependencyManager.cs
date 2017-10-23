using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Oregon.Core.Infrastructure;
using Oregon.Core.Repository;

namespace Oregon.UI.App_Start
{
    public class DependencyManager
    {
        public static void Initialize()
        {
            var container = new ContainerBuilder();
            var build = RegisterServices(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(build));
        }

        private static ILifetimeScope RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterType<TeamProfileRepository>().As<ITeamProfileRepository>();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            return builder.Build();
        }
    }
}