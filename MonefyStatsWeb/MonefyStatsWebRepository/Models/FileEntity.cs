using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MonefyStats.Repository.Models
{
    public class FileEntity
    {
        [BsonId]
        public string Id { get; set; }
        public string Body { get; set; }
        public byte[] Content { get; set; }
        public string Name { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime CreatedOn { get; set; }
        public int UserId { get; set; }
    }
}
