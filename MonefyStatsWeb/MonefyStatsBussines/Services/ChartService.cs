using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var transactions = _monefyTransactionService.GetTransactionsFromFile(file).OrderBy(el => el.Date);
            
            var result = new LineChart
            {
                Data = new ChartJs.Data
                {
                    Datasets = new List<ChartJs.Dataset>
                    {
                        new ChartJs.Dataset
                        {
                            Label = "My First from JSON",
                            Data = transactions.Select(el=> el.Price.Value)
                        }
                    },
                    Labels = transactions.Select(el=> el.Date.ToString("dd/MM/yyyy"))
                },
                Options = new ChartJs.Options(),
                Type = "line"
            };

            return result;
        }
    }
}
