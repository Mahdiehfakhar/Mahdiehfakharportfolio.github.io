namespace BlazorApp.Models;

public class SiteProperties
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? DevDotTo { get; set; } = string.Empty;
    public string GitHub { get; set; } = string.Empty;
    public string Instagram { get; set; } = string.Empty;
    public string LinkedIn { get; set; } = string.Empty;
    public string Medium { get; set; } = string.Empty;
    public string Twitter { get; set; } = string.Empty;
    public string YouTube { get; set; } = string.Empty;
    public string? X { get; set; } = string.Empty;
    public List<LanguageSpecificProperties> Languages { get; set; } = new List<LanguageSpecificProperties>();
}

public class LanguageSpecificProperties
{
    public string LangCode { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string CreatedByText { get; set; } = string.Empty;
}