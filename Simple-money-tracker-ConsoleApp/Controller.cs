using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace Simple_money_tracker_ConsoleApp
{
    public class Controller
    {
        private static string Url { get; set; } = "https://simple-money-tracker.herokuapp.com/projects";       

        #region Projects

        public static string GetAllProjets()
        {
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(Url);
                var responseJson = JsonConvert.DeserializeObject<Project[]>(response);
                var responseJsonString = JsonConvert.SerializeObject(responseJson, Formatting.Indented);

                return responseJsonString;
            }
        }
        
        public static string GetProject(string projectId)
        {
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(Url + "/" + projectId);
                var responseJson = JsonConvert.DeserializeObject<Project>(response);
                var responseJsonString = JsonConvert.SerializeObject(responseJson, Formatting.Indented);

                return responseJsonString;
            }
        }
        
        public static string CreateProject(Project project)
        {
            using (var webClient = new WebClient())
            {
                webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                var projectJson = JsonConvert.SerializeObject(project, Formatting.Indented);
                    
                var response = webClient.UploadData(Url, "POST", Encoding.ASCII.GetBytes(projectJson));
                return Encoding.ASCII.GetString(response);
            }
        }
        
        public static string DeleteProject(Project project)
        {
            using (var webClient = new WebClient())
            {
                webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                var projectJson = JsonConvert.SerializeObject(project, Formatting.Indented);
                    
                var response = webClient.UploadData(Url, "DELETE", Encoding.ASCII.GetBytes(projectJson));
                return Encoding.ASCII.GetString(response);
            }
        }

        #endregion
        
        #region Categories

        public static string GetAllCategories(string projectId)
        {
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(Url + "/" + projectId + "/categories");
                var responseJson = JsonConvert.DeserializeObject<List<Category>>(response);
                var responseJsonString = JsonConvert.SerializeObject(responseJson, Formatting.Indented);

                return responseJsonString;
            }
        }

        public static string GetCategory(string projectId ,string categoryId)
        {
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(Url + "/" + projectId + "/categories/" + categoryId);
                var responseJson = JsonConvert.DeserializeObject<Category>(response);
                var responseJsonString = JsonConvert.SerializeObject(responseJson, Formatting.Indented);

                return responseJsonString;
            }
        }
        
        #endregion
        
        #region Transactions

        

        #endregion
    }
}