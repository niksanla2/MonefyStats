using System;
using System.Collections.Generic;
using System.Text;
using MonefyStats.Bussines.Models;

namespace MonefyStats.Bussines.Services
{
    public interface IMonefyTransactionService
    {
        IEnumerable<MonefyTransaction> GetTransactionsFromFile(FileBussines file);
    }
}
