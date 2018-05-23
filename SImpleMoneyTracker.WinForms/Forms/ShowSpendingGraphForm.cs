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
using SImpleMoneyTracker.WinForms.Implementation.Models;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace SImpleMoneyTracker.WinForms
{
    public partial class ShowSpendingGraphForm : Form
    {
        public ShowSpendingGraphForm()
        {
            InitializeComponent();
            InitializeSpendingGraph();  

        }

        public void InitializeSpendingGraph()
        {
            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<Project>("projectdbcollection");

            var projectCollectionQueryable = projectCollection.AsQueryable();
            var projectCollectionList = projectCollectionQueryable.ToList();

            var project = projectCollectionList.First();

            var areaSeries = new AreaSeries();

            foreach (var category in project.Categories)
            {
                areaSeries.DataPoints.Add(new CategoricalDataPoint((double) category.Amount, category.CategoryName));
            }

            //areaSeries.DataPoints.Add(new CategoricalDataPoint(13, "Jan"));
            //areaSeries.DataPoints.Add(new CategoricalDataPoint(20, "Apr"));
            //areaSeries.DataPoints.Add(new CategoricalDataPoint(15, "Jul"));
            //areaSeries.DataPoints.Add(new CategoricalDataPoint(16, "Oct"));

            radChartViewSpendingGraph.Series.Add(areaSeries);
        }


    }
}
