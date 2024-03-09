namespace FluentBuilderApp;

public class SocialMediaPostBuilder
{
    private readonly SocialMediaPost _post = new SocialMediaPost();

    public SocialMediaPostBuilder AddTitle(string title)
    {
        _post.Title = title;
        return this;
    }

    public SocialMediaPostBuilder AddContent(string content)
    {
        _post.Content = content;
        return this;
    }

    public SocialMediaPostBuilder AddAuthor(string author)
    {
        _post.Author = author;
        return this;
    }

    public SocialMediaPostBuilder AddTag(string tag)
    {
        if (_post.Tags is null)
        {
            _post.Tags = new List<string>();
        }
        _post.Tags.Add(tag);
        return this;
    }

    public SocialMediaPostBuilder AddLink(Uri link)
    {
        if (_post.Links is null)
        {
            _post.Links = new List<Uri>();
        }
        _post.Links.Add(link);
        return this;
    }

    public SocialMediaPostBuilder SetPostDate(DateTime datePosted)
    {
        _post.DatePosted = datePosted;
        return this;
    }

    public SocialMediaPostBuilder AddImage(Uri image)
    {
        _post.ImageUri = image;
        return this;
    }

    public SocialMediaPost Build()
    {
        return _post;
    }
}
