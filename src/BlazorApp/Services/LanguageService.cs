public class LanguageService
{
    public string CurrentLanguage { get; private set; } = "English";
    public string CurrentLanguageCode { get; private set; } = "en";
    public event Action OnLanguageChanged;

    public void SetLanguage(string langCode, string languageName)
    {
        CurrentLanguageCode = langCode;
        CurrentLanguage = languageName;
        OnLanguageChanged?.Invoke();
    }
}