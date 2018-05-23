using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Simple_money_tracker_Core.Abstractions.Models
{
    public interface IProject
    {
        [BsonElement("categories")]
        IList<ICategory> Categories { get; set; }

        [BsonElement("projectBalance")]
        decimal ProjectBalance { get; }

        [BsonElement("projectBudget")]
        decimal ProjectBudget { get; set; }

        [BsonId, BsonIgnoreIfNull, BsonRepresentation(BsonType.ObjectId)]
        string ProjectId { get; set; }

        [BsonElement("projectName")]
        string ProjectName { get; set; }
    }
}