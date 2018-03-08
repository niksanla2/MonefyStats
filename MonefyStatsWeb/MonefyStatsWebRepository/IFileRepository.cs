using MonefyStats.Repository.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MonefyStats.Repository
{
    public interface IFileRepository
    {
        Task<IEnumerable<FileEntity>> GetAllFiles();
        Task<FileEntity> GetFile(string id);
        Task AddFile(FileEntity item);
        Task<DeleteResult> RemoveFile(string id);
        // обновление содержания (body) записи
        Task<UpdateResult> UpdateFile(string id, string body);
    }
}
