using Autofac;
using Autofac.Core;
using MonefyStats.Bussines.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonefyStats.Web.Registration
{
    public class BussinesAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder
                .RegisterType<FileService>()
                .As<IFileService>();

        }


    }
}
