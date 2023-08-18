namespace logit_api.Entities
{
	public class WeatherForecast
	{
		public DateOnly Date { get; set; }
		public int TemperatureC { get; set; }
		public string Summary { get; set; }
	}

	public class Book
	{
		public string Title { get; set; }

		public Author Author { get; set; }
	}

	public class Author
	{
		public string Name { get; set; }
	}

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

		public WeatherForecast[] GetWeatherForecast() =>
			new WeatherForecast[]
			{
				new WeatherForecast
				{
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
					TemperatureC = 20,
					Summary = "Warm"
				},
				new WeatherForecast
				{
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(2)),
					TemperatureC = 25,
					Summary = "Hot"
				},
				new WeatherForecast
				{
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(3)),
					TemperatureC = 15,
					Summary = "Cold"
				},
				new WeatherForecast
				{
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(4)),
					TemperatureC = 10,
					Summary = "Freezing"
				},
				new WeatherForecast
				{
					Date = DateOnly.FromDateTime(DateTime.Now.AddDays(5)),
					TemperatureC = 30,
					Summary = "Scorching"
				}
			};
	}


}