using Autofac;
using Microsoft.Extensions.Configuration;
using MonefyStats.Repository;
using MonefyStats.Repository.Registration;


namespace MonefyStats.Web.Registration
{

    //TODO: mb remove this file in repo without Configura
    public class RepositoryAutofacModule : Module
    {
        private readonly IConfiguration _configuration;
        public RepositoryAutofacModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            builder
                .Register(c => new Settings
                {
                    ConnectionString = _configuration.GetSection("MongoConnection:ConnectionString").Value,
                    Database = _configuration.GetSection("MongoConnection:Database").Value
                })
                .As<ISettings>()
                .SingleInstance();

            builder
                .RegisterType<FileRepository>()
                .As<IFileRepository>();
        }
    }
}
