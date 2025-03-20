using System.Text.Json.Serialization;

namespace BlazorApp.Models
{
    public class ProjectLanguage
    {
        public string LangCode { get; set; } = string.Empty;
        public string PortfolioText { get; set; } = string.Empty;
        public List<Project> Projects { get; set; } = new List<Project>();
    }
}
