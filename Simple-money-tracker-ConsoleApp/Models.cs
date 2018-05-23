using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Simple_money_tracker_ConsoleApp
{
    public sealed class Project
    {
        [JsonProperty("categories")]
        public IList<Category> Categories { get; set; }
       
        [JsonProperty("projectBalance")]
        public decimal ProjectBalance { get; set; }
        
        [JsonProperty("projectBudget")]
        public decimal ProjectBudget { get; set; }
        
        [JsonProperty("projectId")]
        public string ProjectId { get; set; }
        
        [JsonProperty("projectName")]
        public string ProjectName { get; set; }
    }
       
    public sealed class Category
    {
        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }
        
        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }
        
        [JsonProperty("transactions")]
        public IList<Transaction> Transactions { get; set; }

        [JsonIgnore]
        public decimal Amount =>
            Transactions.Equals(null) ? 0 : Transactions.Select(transaction => transaction.Amount).Sum();
    }
    
    public class Transaction
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }
        
        [JsonProperty("instant")]
        public DateTime Instant { get; set; }
        
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }
        
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}