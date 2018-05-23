using System.Collections.Generic;
using Newtonsoft.Json;

namespace Simple_money_tracker_ConsoleApp
{
    public static class Extensions
    {
        public static List<Project> ToProjects(this string projectsJson)
        {
            return JsonConvert.DeserializeObject<List<Project>>(projectsJson);
        }

        public static Project ToProject(this string projectJson)
        {
            return JsonConvert.DeserializeObject<Project>(projectJson);
        }
    }
}