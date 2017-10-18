using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Oregon.Core.Infrastructure;
using Oregon.Core.Repository;

namespace Oregon.UI.Dependency
{
    public class Bootstrapper
    {
        public static void RunConfig()
        {
            BuildAutoFAc();
        }

        private static void BuildAutoFAc()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TeamProfileRepository>().As<ITeamProfileRepository>();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }

    }
}