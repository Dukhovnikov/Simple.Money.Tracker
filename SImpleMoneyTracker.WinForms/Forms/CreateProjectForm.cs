using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using Simple_money_tracker_Core.Abstractions;
using Simple_money_tracker_Core.Abstractions.Models;
using SImpleMoneyTracker.WinForms.Implementation.Models;

namespace SimpleMoneyTracker.WinForms
{
    public partial class CreateProjectForm : Form
    {
        public CreateProjectForm()
        {
            InitializeComponent();
        }

        private void radButtonCreateProject_Click(object sender, EventArgs e)
        {
            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<Project>("projectdbcollection");

            var project = new Project()
            {
                ProjectName = radTextBoxProjectName.Text,
                ProjectBudget = decimal.Parse(radTextBoxProjectBalance.Text)
            };

            projectCollection.InsertOne(project);

            Close();
        }
    }
}
