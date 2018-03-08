using MonefyStats.Repository.Model;
using MonefyStats.Repository.Registration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonefyStats.Repository
{
    public class FileDbContext
    {
        private readonly IMongoDatabase _database = null;
        public FileDbContext(ISettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.Database);
            }
        }
        public IMongoCollection<FileEntity> Files
        {
            get
            {
                return _database.GetCollection<FileEntity>("Files");
            }
        }
    }
}
