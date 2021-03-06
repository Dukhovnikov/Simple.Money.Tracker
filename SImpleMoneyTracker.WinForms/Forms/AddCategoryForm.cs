﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using Simple_money_tracker_Core.Abstractions;
using Simple_money_tracker_Core.Abstractions.Models;
using SImpleMoneyTracker.WinForms.Implementation.Models;

namespace SimpleMoneyTracker.WinForms
{
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
        }

        private void radButtonAddCategory_Click(object sender, EventArgs e)
        {
            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<Project>("projectdbcollection");

            var project = projectCollection.AsQueryable().First();

            if (project.Categories == null)
            {
                project.Categories = new List<Category>();
            }

            var category = new Category()
            {
                CategoryName = radTextBoxCategoryName.Text
            };

            project.Categories.Add(category);

            var filter = Builders<Project>.Filter.Eq(w => w.ProjectId, project.ProjectId);

            var result = projectCollection.ReplaceOne(
                filter, 
                project,
                new UpdateOptions {IsUpsert = true});

            Close();
        }
    }
}
