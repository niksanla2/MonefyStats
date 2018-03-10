using System;
using System.Collections.Generic;
using System.Text;

namespace MonefyStats.ChartJs
{
    public class Data
    {
        public IEnumerable<string> Labels { get; set; }
        public IEnumerable<Dataset> Datasets { get; set; }
    }
}
