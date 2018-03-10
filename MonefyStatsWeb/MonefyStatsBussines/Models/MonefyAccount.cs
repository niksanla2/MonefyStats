using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonefyStats.Bussines.Models
{
    public class MonefyAccount
    {
        public MonefyAccount(IEnumerable<MonefyTransaction> transactions, string accountName)
        {
            Transactions = transactions;
            Name = accountName;
        }
        public string Name { get; }
        public IEnumerable<MonefyTransaction> Transactions { get; }
        public IEnumerable<decimal?> GetDataByDay(DateTime fromDate, DateTime toDate, TransactionType transactionType)
        {
            var resultData = new List<decimal?>();
            if (fromDate >= toDate)
            {
                return resultData;
            }
            var currentDate = fromDate;
            var transactions = Transactions.Where(el => el.TransactionType == transactionType);

            while (currentDate < toDate)
            {
                var curentDayTransactions = transactions.Where(el => el.Date == currentDate).ToList();
                if (!curentDayTransactions.Any())
                {
                    resultData.Add(null);
                }
                else
                {
                    resultData.Add(curentDayTransactions.Sum(el => el.Price.Value));
                }
                currentDate = currentDate.AddDays(1);
            }
            return resultData;
        }
    }
}
