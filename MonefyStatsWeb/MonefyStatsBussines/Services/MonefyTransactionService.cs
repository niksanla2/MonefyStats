﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MonefyStats.Bussines.Models;

namespace MonefyStats.Bussines.Services
{
    public class MonefyTransactionService : IMonefyTransactionService
    {
        public IEnumerable<MonefyTransaction> GetTransactionsFromFile(FileBussines file)
        {
            var scvFile = Encoding.UTF8.GetString(file.Content);
            var lines = scvFile.Split("\n").Skip(1).Where(el=> !string.IsNullOrEmpty(el));
            return lines.Select(MonefyTransaction.ConvertFromString).ToList();
        }
    }
}
