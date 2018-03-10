using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Bussines.Models;

namespace MonefyStats.Bussines.Services
{
    public interface IProfileService
    {
        Task<MonefyProfile> GetProfileByIdAsync(string id);
        Task<string> SaveProfileAsync(FileBussines fileBussines);
    }
}
