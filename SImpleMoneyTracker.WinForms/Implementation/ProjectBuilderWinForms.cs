using System.Configuration;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using Simple_money_tracker_Core.Abstractions;
using Simple_money_tracker_Core.Abstractions.Models;

namespace SimpleMoneyTracker.WinForms.Implementation
{
    internal class ProjectBuilderWinForms : IProjectBuilder
    {
        public void CreateProject()
        {
            var createProjectForm = new CreateProjectForm();
            createProjectForm.ShowDialog();
        }

        public bool IsProjectExist()
        {
            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<IProject>("projectdbcollection");
            var projectCollectionCount = projectCollection.Count(new BsonDocument());

            return projectCollectionCount > 0;
        }
    }
}
