using System;
using System.Collections.Generic;

namespace MonefyStats.ChartJs
{
    public class Dataset
    {
        public string Label { get; set; }
        public IEnumerable<decimal?> Data { get; set; }
    }
}
