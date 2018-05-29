using System.Configuration;
using System.Linq;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using SImpleMoneyTracker.WinForms.Implementation.Models;

namespace SimpleMoneyTracker.WinForms
{
    public class Repository : IRepository
    {
        private readonly IMongoCollection<Project> _mongoCollection;
        
        public Project Projects { get; set; }       

        public Repository()
        {
            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var mongoDatabase = client.GetDatabase("projectdb");
            _mongoCollection = mongoDatabase.GetCollection<Project>("projectdbcollection");

            Projects = _mongoCollection.AsQueryable().First();
        }


        public void Add(Category entity) => Projects.Categories.Add(entity);

        public void Remove(Category entity) => Projects.Categories.Remove(entity);

        public void Add(Category category, Transaction transaction) =>
            Projects.Categories
                .First(c => c.Equals(category))
                .Transactions.Add(transaction);

        public void Remove(Transaction transaction) => Projects.Categories
            .First(category => category.Transactions.Contains(transaction))
            .Transactions.Remove(transaction);
        
        public void SaveChanges()
        {
            var filter = Builders<Project>.Filter.Eq(p => p.ProjectId, Projects.ProjectId);
            _mongoCollection.ReplaceOne(filter, Projects, new UpdateOptions() {IsUpsert = true});
        }
    }
}