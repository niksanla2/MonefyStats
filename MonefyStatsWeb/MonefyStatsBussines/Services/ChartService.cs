using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Bussines.Models;
using MonefyStats.ChartJs;
using MonefyStats.ChartJs.Charts;

namespace MonefyStats.Bussines.Services
{
    public class ChartService : IChartService
    {
        private readonly IFileService _fileService;
        private readonly IMonefyTransactionService _monefyTransactionService;

        public ChartService(IFileService fileService, IMonefyTransactionService monefyTransactionService)
        {
            _fileService = fileService;
            _monefyTransactionService = monefyTransactionService;
        }
        public async Task<LineChart> GetLineChartDataAsync(string id)
        {
            var file = await _fileService.LoadAsync(id);
            if (file == null)
            {
                return null;
            }
            var transactions = _monefyTransactionService.GetTransactionsFromFile(file);
            var monefyProfile = new MonefyProfile(transactions);
            var start = new DateTime(2018, 2, 15);
            var end = new DateTime(2018, 3, 3);

            var result = new LineChart
            {
                Data = new ChartJs.Data
                {
                    Datasets = monefyProfile.Accounts.Select(account =>
                     new Dataset
                     {
                         Label = account.Name,
                         Data = account.GetDataByDay(start, end),
                         BackgroundColor = null
                     }),
                   
                    Labels = Enumerable.Range(0, 1 + end.Subtract(start).Days)
                        .Select(offset => start.AddDays(offset).ToString("dd/MM/yyyy"))

                },
                Options = new ChartJs.Options
                {
                    SpanGaps = true
                },
                Type = ChartType.Line
            };

            return result;
        }
    }
}
