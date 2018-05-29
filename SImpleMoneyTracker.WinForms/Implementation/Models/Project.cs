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
    public class Project
    {
        [BsonElement("categories")]
        public IList<Category> Categories { get; set; }

        [BsonElement("projectBalance")]
        public decimal ProjectBalance =>
            ProjectBudget - Categories?
                .Select(category => category.Transactions?
                    .Select(transaction => transaction.Amount)
                    .Sum())
                .Sum() ?? ProjectBudget;

        [BsonElement("projectBudget")]
        public decimal ProjectBudget { get; set; }

        [BsonId, BsonIgnoreIfNull, BsonRepresentation(BsonType.ObjectId)]
        public string ProjectId { get; set; }

        [BsonElement("projectName")]
        public string ProjectName { get; set; }
    }
}
