using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Repository;
using MonefyStats.Repository.Models;

namespace MonefyStats.Bussines.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;

        public FileService(IFileRepository fileRepository)
        {
            _fileRepository = fileRepository;
        }
        public async Task<string> LoadAsync(string fileId)
        {
            var file = await _fileRepository.GetFileAsync(fileId);
            return file?.Body;
        }

        public async Task<string> SaveAsync(byte[] content)
        {

            return await _fileRepository.AddFileAsync(new FileEntity
            {
                Content = content
            });
        }
    }
}
