using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Simple_money_tracker_Core.Abstractions.Models
{
    public interface ICategory
    {
        [BsonId, BsonIgnoreIfNull, BsonRepresentation(BsonType.ObjectId)]
        string CategoryId { get; set; }

        [BsonElement("categoryName")]
        string CategoryName { get; set; }

        [BsonElement("transactions")]
        IList<ITransaction> Transactions { get; set; }
    }
}