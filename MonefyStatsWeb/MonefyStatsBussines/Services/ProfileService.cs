using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Bussines.Models;

namespace MonefyStats.Bussines.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IFileService _fileService;
        private readonly IMonefyTransactionService _monefyTransactionService;

        public ProfileService(IFileService fileService, IMonefyTransactionService monefyTransactionService)
        {
            _fileService = fileService;
            _monefyTransactionService = monefyTransactionService;
        }

        public async Task<MonefyProfile> GetProfileByIdAsync(string id)
        {
            var file = await _fileService.LoadAsync(id);
            if (file == null)
            {
                return null;
            }
            var transactions = _monefyTransactionService.GetTransactionsFromFile(file);
            return new MonefyProfile(transactions);
        }

        public async Task<string> SaveProfileAsync(FileBussines fileBussines)
        {
           return await _fileService.SaveAsync(fileBussines);
        }
    }
}
