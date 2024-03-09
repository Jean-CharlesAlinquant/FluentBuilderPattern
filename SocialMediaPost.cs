namespace FluentBuilderApp;

public record SocialMediaPost
{
    public string? Title { get; set; }

    public string? Content { get; set; }

    public string? Author { get; set; }
    public DateTime DatePosted { get; set; }

    public List<string>? Tags { get; set; }

    public Uri? ImageUri { get; set; }

    public List<Uri>? Links { get; set; }
}
