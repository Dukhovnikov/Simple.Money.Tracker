using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Simple_money_tracker_Core.Abstractions.Models
{
    public interface ITransaction
    {
        [BsonElement("comment")]
        string Comment { get; set; }

        [BsonElement("instant")]
        DateTime Instant { get; set; }

        [BsonId, BsonIgnoreIfNull, BsonRepresentation(BsonType.ObjectId)]
        string TransactionId { get; set; }

        [BsonElement("amount")]
        decimal Amount { get; set; }
    }
}