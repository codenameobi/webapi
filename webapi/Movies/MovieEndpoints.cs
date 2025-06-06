namespace webapi.Movies;

public static class MovieEndpoints
{
    public static void MapEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("movies");
        
        
    }
}