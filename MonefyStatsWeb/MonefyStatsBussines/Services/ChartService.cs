using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Bussines.Models;
using MonefyStats.ChartJs;

namespace MonefyStats.Bussines.Services
{
    public class ChartService : IChartService
    {

        public Chart GetLineChartData(MonefyProfile monefyProfile)
        {

            var start = new DateTime(2018, 2, 15);
            var end = new DateTime(2018, 3, 3);

            var result = new Chart
            {
                Data = new ChartJs.Data
                {
                    Datasets = monefyProfile.Accounts.Select(account =>
                     new Dataset
                     {
                         Label = account.Name,
                         Data = account.GetDataByDay(start, end, TransactionType.Expense).Select(el => el * -1),
                         BackgroundColor = ColorsRgba.Random(0.9m)
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
