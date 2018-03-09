using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MonefyStats.Bussines.Models;
using MonefyStats.Repository;
using MonefyStats.Repository.Models;

namespace MonefyStats.Bussines.Services
{
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileRepository;
        private readonly IMapper _mapper;

        public FileService(IFileRepository fileRepository, IMapper mapper)
        {
            _fileRepository = fileRepository;
            _mapper = mapper;
        }
        public async Task<FileBussines> LoadAsync(string fileId)
        {
            var file = await _fileRepository.GetFileAsync(fileId);
            return _mapper.Map<FileBussines>(file);
        }

        public async Task<string> SaveAsync(FileBussines file)
        {
            return await _fileRepository.AddFileAsync(_mapper.Map<FileEntity>(file));
        }
    }
}
