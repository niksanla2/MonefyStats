using System;
using System.Collections.Generic;
using System.Text;

namespace MonefyStats.Repository.Registration
{
    public interface ISettings
    {
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}
