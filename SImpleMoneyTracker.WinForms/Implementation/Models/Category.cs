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
    internal class Category
    {
        [BsonId, BsonIgnoreIfNull, BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }

        [BsonElement("categoryName")]
        public string CategoryName { get; set; }

        [BsonElement("transactions")]
        public IList<Transaction> Transactions { get; set; }

        [BsonIgnore]
        public decimal Amount =>
            Transactions?.Select(transaction => transaction.Amount).Sum() ?? 0;
    }
}
