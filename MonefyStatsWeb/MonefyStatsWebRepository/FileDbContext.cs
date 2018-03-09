using MonefyStats.Repository.Registration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using MonefyStats.Repository.Models;

namespace MonefyStats.Repository
{
    public class FileDbContext
    {
        private readonly IMongoDatabase _database = null;
        public FileDbContext(ISettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            _database = client.GetDatabase(settings.Database);
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
