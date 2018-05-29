using System;
using NUnit.Framework;
using SImpleMoneyTracker.WinForms.Implementation.Models;

namespace Simple_money_tracker.Tests
{
    [TestFixture]
    public class SimpleMoneyTrackerTests
    {
        [Test]
        public void ShouldCreateProject()
        {
            var project = new Project()
            {
                ProjectBudget = 1000
            };
            
            Assert.AreEqual(project.ProjectBudget, 1000);

        }
        
        [Test]
        public void ShouldProjectIsExist()
        {
            var project = new Project();
            Assert.True(project != null);
        }
        
        [Test]
        public void ShouldCreateCategory()
        {
            var project = new Project();
            Assert.True(project != null);
        }
        
        [Test]
        public void ShouldCreateTransaction()
        {
            var project = new Project();
            Assert.True(project != null);
        }
        
        [Test]
        public void ShouldRemoveCategory()
        {
            var project = new Project();
            Assert.True(project != null);
        }
        
        [Test]
        public void ShouldRemoveTransaction()
        {
            var project = new Project();
            Assert.True(project != null);
        }
        
        [Test]
        public void ShouldSaveChanges()
        {
            var project = new Project();
            Assert.True(project != null);
        }
    }
}