using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Simple_money_tracker_Core.Abstractions.Models;

namespace SImpleMoneyTracker.WinForms.Implementation.Models
{
    public class Transaction 
    {
        [BsonElement("comment")]
        public string Comment { get; set; }

        [BsonElement("instant")]
        public DateTime Instant { get; set; }

        [BsonId, BsonIgnoreIfNull, BsonRepresentation(BsonType.ObjectId)]
        public string TransactionId { get; set; }

        [BsonElement("amount")]
        public decimal Amount { get; set; }
    }
}
