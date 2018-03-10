using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.ChartJs.Charts;

namespace MonefyStats.Bussines.Services
{
    public interface IChartService
    {
        Task<LineChart> GetLineChartDataAsync(string id);
    }
}
