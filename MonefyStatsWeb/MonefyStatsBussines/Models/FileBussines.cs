using System;
using System.Collections.Generic;
using System.Text;

namespace MonefyStats.Bussines.Models
{
    public class FileBussines
    {
        public string Id { get; set; }
        public string Body { get; set; }
        public string Name { get; set; }
        public byte[] Content { get; set; }
    }
}
