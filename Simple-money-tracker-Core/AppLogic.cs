using System;
using Simple_money_tracker_Core.Abstractions;

namespace Simple_money_tracker_Core
{
    public class AppLogic
    {
        public void Run(IRegistry registry)
        {
            var projectBuilder = registry.ProjectBuilder;
            var showDataToUser = registry.ShowDataToUser;
            
            if (!projectBuilder.IsProjectExist())
            {
                projectBuilder.CreateProject();
            }

            showDataToUser.RunDialog();
        }
    }
}