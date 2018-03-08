using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Repository.Model;
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
            var filter = Builders<FileEntity>.Filter.Eq(s => s.Id, id);
            return filter;
        }
        public FileRepository(ISettings settings)
        {
            _context = new FileDbContext(settings);
            _settings = settings;
        }
        public async Task AddFile(FileEntity item)
        {
            await _context.Files.InsertOneAsync(item);
        }

        public async Task<IEnumerable<FileEntity>> GetAllFiles()
        {
            return await _context.Files.Find(el => true).ToListAsync();
        }

        public async Task<FileEntity> GetFile(string id)
        {
            
            return await _context
                .Files
                .Find(filter)
                .FirstOrDefaultAsync();
        }

        public async Task<DeleteResult> RemoveFile(string id)
        {
            return await _context.Files.DeleteOneAsync(Builders<FileEntity>.Filter.Eq(s => s.Id, id));
        }

        public async Task<UpdateResult> UpdateFile(string id, string body)
        {
            var filter = Builders<FileEntity>.Filter.Eq(s => s.Id, id);

            return await _context.Files.UpdateOneAsync();
        }
    }
}
