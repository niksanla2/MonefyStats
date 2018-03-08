using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonefyStats.Bussines.Services
{
    public interface IFileService
    {
        Task<Guid> SaveAsync(string content);
        Task<string> LoadAsync(Guid fileId);
    }
}
