using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using SmartShares;
using static System.Text.Encoding;


namespace Simple_money_tracker_ConsoleApp
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            //var projetsJson = Controller.GetAllProjets();
            //Console.WriteLine(projetsJson);

            var tranz1 = new Transaction()
            {
                Amount = 485,
                Comment = "No comment",
                Instant = DateTime.Now,
                TransactionId = HexConvert.FromBytes(Hash.ComputeSha256FromString("transactionId1"))
            };

            var tranz2 = new Transaction()
            {
                Amount = 685,
                Comment = "No comment",
                Instant = DateTime.Now,
                TransactionId = HexConvert.FromBytes(Hash.ComputeSha256FromString("transactionId2"))
            };

            var categ1 = new Category()
            {
                CategoryId = HexConvert.FromBytes(Hash.ComputeSha256FromString("categoryId1")),
                CategoryName = "My Category 1",
                Transactions = new List<Transaction>() {tranz1},
            };

            var categ2 = new Category()
            {
                CategoryId = HexConvert.FromBytes(Hash.ComputeSha256FromString("categoryId2")),
                CategoryName = "My Category 2",
                Transactions = new List<Transaction>() {tranz1},
            };

            var categ3 = new Category()
            {
                CategoryId = HexConvert.FromBytes(Hash.ComputeSha256FromString("categoryId3")),
                CategoryName = "My Category 3",
                Transactions = new List<Transaction>() { tranz1 },
            };

            var categ4 = new Category()
            {
                CategoryId = HexConvert.FromBytes(Hash.ComputeSha256FromString("categoryId4")),
                CategoryName = "My Category 4",
                Transactions = new List<Transaction>() { tranz1 },
            };

            var project = new Project()
            {
                Categories = new List<Category>() {categ1, categ2, categ3, categ4},
                ProjectBudget = 25000,
                ProjectId = HexConvert.FromBytes(Hash.ComputeSha256FromString("projectId1")),
                ProjectName = "My Project 1"
            };


            var jsonProject = JsonConvert.SerializeObject(project, Formatting.Indented);
            
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SimpleMoneyDB.txt", jsonProject);
        }        
    }
}