﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MonefyStats.Bussines.Models;
using MonefyStats.ChartJs;

namespace MonefyStats.Bussines.Services
{
    public interface IChartService
    {
        Chart GetLineChartData(MonefyProfile monefyProfile);
    }
}
