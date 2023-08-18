var builder = WebApplication.CreateBuilder(args);

// add the graphql services
builder.Services
	.AddGraphQLServer()
	.AddQueryType<Query>();

var app = builder.Build();


app.MapGraphQL();
app.MapGet("/", () => "Hello World!");
app.Run();

// define the graphql types

public class Book
{
	public string Title { get; set; }

	public Author Author { get; set; }
}

public class Author
{
	public string Name { get; set; }
}
// define the sample query type

public class Query
{
	public Book GetBook() =>
		new Book
		{
			Title = "C# in depth.",
			Author = new Author
			{
				Name = "Jon Skeet"
			}
		};
}



// add the grapql endpoint


