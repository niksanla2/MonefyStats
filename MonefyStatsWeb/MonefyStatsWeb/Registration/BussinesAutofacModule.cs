using Autofac;
using Autofac.Core;
using Microsoft.Extensions.Configuration;
using MonefyStats.Bussines.Services;
using MonefyStats.Repository.Registration;
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

            builder
                .RegisterType<MonefyTransactionService>()
                .As<IMonefyTransactionService>();

            builder
                .RegisterType<ChartService>()
                .As<IChartService>();
        }
    }
}
