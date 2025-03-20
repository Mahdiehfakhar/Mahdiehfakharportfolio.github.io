using System.Text.Json.Serialization;

namespace BlazorApp.Models;

public class AboutMe
{
    public string LangCode { get; set; } = string.Empty;
    public string AboutMeText { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Skills { get; set; } = new List<string>();
    public string DetailOrQuote { get; set; } = string.Empty;
}