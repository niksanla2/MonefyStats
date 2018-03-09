using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Repository.Models;

namespace MonefyStats.Repository
{
    public interface IFileRepository
    {
        Task<IEnumerable<FileEntity>> GetAllFilesAsync();
        Task<FileEntity> GetFileAsync(string id);
        Task<string> AddFileAsync(FileEntity item);
        Task<DeleteResult> RemoveFileAsync(string id);
        // обновление содержания (body) записи
        Task<UpdateResult> UpdateFileAsync(string id, string body);
    }
}
