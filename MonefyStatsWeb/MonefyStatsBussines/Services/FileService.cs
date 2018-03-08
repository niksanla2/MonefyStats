using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonefyStats.Bussines.Services
{
    public class FileService : IFileService
    {
        public Task<string> LoadAsync(Guid fileId)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> SaveAsync(string content)
        {
            throw new NotImplementedException();
        }
    }
}
