namespace webapi.Movies;

public class Movie
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public required int YearOfRelease { get; set; }
}