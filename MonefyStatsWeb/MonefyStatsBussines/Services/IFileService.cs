using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Bussines.Models;

namespace MonefyStats.Bussines.Services
{
    public interface IFileService
    {
        Task<string> SaveAsync(FileBussines file);
        Task<FileBussines> LoadAsync(string fileId);
    }
}
