using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simple_money_tracker_Core.Abstractions;

namespace SimpleMoneyTracker.WinForms.Implementation
{
    internal class RegistryWinForms : IRegistry
    {
        public IProjectBuilder ProjectBuilder { get; set; }
        public IShowDataToUser ShowDataToUser { get; set; }

        public RegistryWinForms()
        {
            this.ProjectBuilder = new ProjectBuilderWinForms();
            this.ShowDataToUser = new ShowDataToUserWinForms();
        }
    }
}
