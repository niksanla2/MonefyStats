using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonefyStats.Bussines.Services
{
    public interface IFileService
    {
        Task<string> SaveAsync(byte[] content);
        Task<string> LoadAsync(string fileId);
    }
}
