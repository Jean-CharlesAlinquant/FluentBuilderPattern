using FluentBuilderApp;
using static System.Console;

SocialMediaPost post = new SocialMediaPostBuilder()
                            .AddTitle("The Fluent Builder Pattern")
                            .AddContent("Definition of the pattern goes here")
                            .AddAuthor("Jean-Charles Alinquant")
                            .AddTag("#designpatterns")
                            .AddTag("#csharp")
                            .SetPostDate(DateTime.Now)
                            .AddLink(new Uri("https://www.google.com"))
                            .AddImage(new Uri("https://www.google.com"))
                            .Build();

WriteLine(post.ToString());
