using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Simple_money_tracker_ConsoleApp
{
    public static class ExecuterDesktop
    {
        private static readonly string PathToDb = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                     "\\SimpleMoneyDB.txt";

        public static Project GetProjectDb()
        {
            var jsonProject = File.ReadAllText(PathToDb);
            var project = JsonConvert.DeserializeObject<Project>(jsonProject);

            return project;
        }

        public static void UpdateDb(Project project)
        {
            var jsonProject = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(PathToDb, jsonProject);
        }

        public static void AddCategory(Project project, Category category)
        {
            project.Categories.Add(category);
            UpdateDb(project);
        }

        public static void AddTransaction(Project project, string categoryid, Transaction transaction)
        {
            foreach (var category in project.Categories)
            {
                if (category.CategoryId.Equals(categoryid))
                {
                    category.Transactions.Add(transaction);
                }
            }

            UpdateDb(project);
        }

    }
}
