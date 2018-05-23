using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Simple_money_tracker_Core.Abstractions;
using SImpleMoneyTracker.WinForms.Implementation.Models;

namespace SimpleMoneyTracker.WinForms
{
    public partial class AddTransactionForm : Form
    {
        public AddTransactionForm()
        {
            InitializeComponent();

            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<Project>("projectdbcollection");

            var projectCollectionQueryable = projectCollection.AsQueryable();
            var projectCollectionList = projectCollectionQueryable.ToList();

            foreach (var category in projectCollectionList.First().Categories)
            {
                comboBoxSelectCategory.Items.Add(category.CategoryName);
            }

            comboBoxSelectCategory.SelectedIndex = 0;
        }

        private void radButtonAddTransaction_Click(object sender, EventArgs e)
        {
            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<Project>("projectdbcollection");

            var project = projectCollection.AsQueryable().First();

            var transaction = new Transaction()
            {
                Amount = decimal.Parse(textBoxTransactionAmount.Text),
                Instant = monthCalendarForTransaction.SelectionStart.Date,
                Comment = textBoxTransactionComment.Text,
            };

            foreach (var category in project.Categories)
            {
                if (category.CategoryName.Equals(comboBoxSelectCategory.Text))
                {
                    if (category.Transactions == null)
                    {
                        category.Transactions = new List<Transaction>();
                    }

                    category.Transactions.Add(transaction);
                }
            }

            var filter = Builders<Project>.Filter.Eq(w => w.ProjectId, project.ProjectId);

            var result = projectCollection.ReplaceOne(
                filter,
                project,
                new UpdateOptions { IsUpsert = true });

            Close();
        }

        private void radLabel5_Click(object sender, EventArgs e)
        {

        }

        private void AddTransactionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
