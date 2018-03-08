using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonefyStats.Repository.Model
{
    public class FileEntity
    {
        [BsonId]
        public string Id { get; set; }
        public string Body { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
    }
}
