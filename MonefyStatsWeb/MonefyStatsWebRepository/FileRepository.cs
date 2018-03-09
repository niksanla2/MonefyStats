using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Repository.Models;
using MonefyStats.Repository.Registration;
using MongoDB.Driver;

namespace MonefyStats.Repository
{
    public class FileRepository : IFileRepository
    {
        private readonly ISettings _settings;
        private readonly FileDbContext _context;
        private FilterDefinition<FileEntity> GetEqFilterById(string id)
        {
            return Builders<FileEntity>.Filter.Eq(s => s.Id, id);
        }
        
        public FileRepository(ISettings settings)
        {
            _context = new FileDbContext(settings);
            _settings = settings;
        }
        public async Task<string> AddFileAsync(FileEntity item)
        {
            var id = Guid.NewGuid().ToString();
            item.Id = id;
            var dateTimeNow = DateTime.UtcNow;
            item.CreatedOn = dateTimeNow;
            item.UpdatedOn = dateTimeNow;
            await _context.Files.InsertOneAsync(item);
            return id;
        }

        public async Task<IEnumerable<FileEntity>> GetAllFilesAsync()
        {
            return await _context.Files.Find(el => true).ToListAsync();
        }

        public async Task<FileEntity> GetFileAsync(string id)
        {
            return await _context
                .Files
                .Find(GetEqFilterById(id))
                .FirstOrDefaultAsync();
        }

        public async Task<DeleteResult> RemoveFileAsync(string id)
        {
            return await _context.Files.DeleteOneAsync(GetEqFilterById(id));
        }

        public async Task<UpdateResult> UpdateFileAsync(string id, string body)
        {
            var update = Builders<FileEntity>.Update
                .Set(s => s.Body, body)
                .CurrentDate(s => s.UpdatedOn);
            return await _context.Files.UpdateOneAsync(GetEqFilterById(id), update);
        }
    }
}
