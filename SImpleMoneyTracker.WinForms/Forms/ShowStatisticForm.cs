using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using Simple_money_tracker_Core.Abstractions;
using Simple_money_tracker_Core.Abstractions.Models;
using SImpleMoneyTracker.WinForms;
using SImpleMoneyTracker.WinForms.Implementation.Models;
using Telerik.Charting;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Gauges;

namespace SimpleMoneyTracker.WinForms
{
    public partial class ShowStatisticForm : Form
    {
        public ShowStatisticForm()
        {
            InitializeComponent();
            InitializePieChart();
            InitializeTreeView();
            InitializeRadialGauge();
            InitializeHead();
        }

        public void InitializeRadialGauge()
        {
            //var labels = new RadialGaugeLabels();
            //var smallTicks = new RadialGaugeTicks();
            //var bigTicks = new RadialGaugeTicks();
            //var needle = new RadialGaugeNeedle();
            //var arc = new RadialGaugeArc();

            //labels.LabelFontSize = 4;
            //smallTicks.TickColor = Color.Red;
            //smallTicks.TickThickness = 0.5f;
            //smallTicks.TicksCount = 30;
            //smallTicks.TickStartIndexVisibleRange = 15;
            //bigTicks.TickColor = Color.DimGray;
            //bigTicks.TickThickness = 1f;
            //bigTicks.TicksCount = 10;
            //bigTicks.TicksLenghtPercentage = 20;
            //bigTicks.TicksRadiusPercentage = 80;
            //needle.LenghtPercentage = 60;
            //arc.Width = 0.5f;
            //arc.BackColor = Color.Gray;

            //radRadialGaugeCurrentMoney = new RadRadialGauge();

            //radRadialGaugeCurrentMoney.Items.Add(labels);
            //radRadialGaugeCurrentMoney.Items.Add(smallTicks);
            //radRadialGaugeCurrentMoney.Items.Add(bigTicks);
            //radRadialGaugeCurrentMoney.Items.Add(needle);
            //radRadialGaugeCurrentMoney.Items.Add(arc);


            //RadialGaugeLabels labels = new RadialGaugeLabels();
            //RadialGaugeTicks smallTicks = new RadialGaugeTicks();
            //RadialGaugeTicks bigTicks = new RadialGaugeTicks();
            //RadialGaugeNeedle needle = new RadialGaugeNeedle();
            //RadialGaugeArc arc = new RadialGaugeArc();
            //labels.LabelFontSize = 4;
            //smallTicks.TickColor = Color.Red;
            //smallTicks.TickThickness = 0.5f;
            //smallTicks.TicksCount = 30;
            //smallTicks.TickStartIndexVisibleRange = 15;
            //bigTicks.TickColor = Color.DimGray;
            //bigTicks.TickThickness = 1f;
            //bigTicks.TicksCount = 10;
            //bigTicks.TicksLenghtPercentage = 20;
            //bigTicks.TicksRadiusPercentage = 80;
            //needle.LenghtPercentage = 60;
            //arc.Width = 0.5f;
            //arc.BackColor = Color.Gray;

            //radRadialGaugeCurrentMoney.Items.Add(labels);
            //radRadialGaugeCurrentMoney.Items.Add(smallTicks);
            //radRadialGaugeCurrentMoney.Items.Add(bigTicks);
            //radRadialGaugeCurrentMoney.Items.Add(needle);
            //radRadialGaugeCurrentMoney.Items.Add(arc);

        }

        public void InitializeHead()
        {
            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<Project>("projectdbcollection");

            var projectCollectionQueryable = projectCollection.AsQueryable();
            var projectCollectionList = projectCollectionQueryable.ToList();

            var project = projectCollectionList.First();

            radLabelProjectName.Text = project.ProjectName;
            radTextBoxCurrentBalance.Text = project.ProjectBalance.ToString(CultureInfo.InvariantCulture);
            radTextBoxSpend.Text = (project.ProjectBudget - project.ProjectBalance).ToString(CultureInfo.InvariantCulture);
        }

        public void InitializeTreeView()
        {
            radTreeViewCategories.Nodes.Clear();

            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<Project>("projectdbcollection");

            var projectCollectionQueryable = projectCollection.AsQueryable();
            var projectCollectionList = projectCollectionQueryable.ToList();

            if (projectCollectionList.First().Categories != null)
            {
                foreach (var category in projectCollectionList.First().Categories)
                {
                    radTreeViewCategories.AddNodeByPath(category.CategoryName);

                    if (category.Transactions != null)
                    {
                        

                        foreach (var transaction in category.Transactions)
                        {
                            radTreeViewCategories.Nodes[category.CategoryName].Nodes
                                .Add(transaction.Amount + "    " + transaction.Comment);
                        }
                    }
                }
            }
        }

        public void InitializePieChart()
        {
            var series = new DonutSeries();

            var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
            var client = new MongoClient(configConnectionString);
            var database = client.GetDatabase("projectdb");
            var projectCollection = database.GetCollection<Project>("projectdbcollection");

            var projectCollectionQueryable = projectCollection.AsQueryable();
            var projectCollectionList = projectCollectionQueryable.ToList();



            if (projectCollectionList.First().Categories != null)
            {
                foreach (var category in projectCollectionList.First().Categories)
                {
                    if (category.Amount > 0)
                    {
                        series.DataPoints.Add(
                            new PieDataPoint(Convert.ToDouble(category.Amount), category.CategoryName));
                    }
                }
            }

            radChartViewCategories.Series.Add(series);
            radChartViewCategories.Area.View.Palette = KnownPalette.Arctic;
        }

        private void radButtonAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var addCategoryForm = new AddCategoryForm();
                addCategoryForm.ShowDialog();

                InitializeTreeView();
                InitializePieChart();
                InitializeHead();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }


        }

        private void radButtonAddTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                var addTransactionForm = new AddTransactionForm();
                addTransactionForm.ShowDialog();

                InitializeTreeView();
                InitializePieChart();
                InitializeHead();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Сначала нужно добавить категорию", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void radButtonShowSpendingGraph_Click(object sender, EventArgs e)
        {
            var spendingGraphForm = new ShowSpendingGraphForm();
            spendingGraphForm.ShowDialog();
        }

        private void radButtonRemoveCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
                var client = new MongoClient(configConnectionString);
                var database = client.GetDatabase("projectdb");
                var projectCollection = database.GetCollection<Project>("projectdbcollection");
                var project = projectCollection.AsQueryable().First();

                var categoryNameForRemove = radTreeViewCategories.SelectedNode.Text;
                var categoryForRemove = new Category();
                foreach (var category in project.Categories)
                {
                    if (category.CategoryName.Equals(categoryNameForRemove))
                    {
                        categoryForRemove = category;
                    }
                }

                project.Categories.Remove(categoryForRemove);

                var filter = Builders<Project>.Filter.Eq(w => w.ProjectId, project.ProjectId);

                var result = projectCollection.ReplaceOne(
                    filter,
                    project,
                    new UpdateOptions { IsUpsert = true });

                InitializeTreeView();
                InitializePieChart();
                InitializeHead();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Сначала нужно выбрать категорию для удаления", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void radButtonRemoveTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                var configConnectionString = ConfigurationManager.ConnectionStrings["mongodb"].ConnectionString;
                var client = new MongoClient(configConnectionString);
                var database = client.GetDatabase("projectdb");
                var projectCollection = database.GetCollection<Project>("projectdbcollection");
                var project = projectCollection.AsQueryable().First();

                var transactionNameForRemove = radTreeViewCategories.SelectedNode.Text;
                var transactionForRemove = new Transaction();

                const string pattern = @"([0-9]*)(    )(\w)";
                var input = Regex.Replace(transactionNameForRemove, pattern, "$3");
                var filter = Builders<Project>.Filter.Eq(w => w.ProjectId, project.ProjectId);

                foreach (var category in project.Categories)
                {
                    foreach (var transaction in category.Transactions)
                    {
                        if (transaction.Comment.Equals(input))
                        {
                            transactionForRemove = transaction;
                        }
                    }
                }

                foreach (var t in project.Categories)
                {
                    if (t.Transactions.Contains(transactionForRemove))
                    {
                        t.Transactions.Remove(transactionForRemove);
                    }
                }

                var result = projectCollection.ReplaceOne(
                    filter,
                    project,
                    new UpdateOptions { IsUpsert = true });

                InitializeTreeView();
                InitializePieChart();
                InitializeHead();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Сначала нужно выбрать транзакцию для удаления", @"Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radTreeViewCategories_SelectedNodeChanged(object sender, RadTreeViewEventArgs e)
        {

        }

        private void radLabelCurrentBalance_Click(object sender, EventArgs e)
        {

        }
    }
}
