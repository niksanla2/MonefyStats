using System;
using System.Collections.Generic;
using System.Text;
using MonefyStats.Bussines.Models;

namespace MonefyStats.Bussines.Services
{
    public interface IMonefyTransactionService
    {
        IList<MonefyTransaction> GetTransactionsFromFile(FileBussines file);
    }
}
