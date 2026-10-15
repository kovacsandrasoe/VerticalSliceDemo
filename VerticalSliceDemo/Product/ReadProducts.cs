namespace VerticalSliceDemo.Product
{
    public class ReadProducts
    {
        public record Response(int Id, string Name, int Price);

        public sealed class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app)
            {
                app
                    .MapGet("product", Handler)
                    .WithTags("Product")
                    .Produces<List<Response>>()
                    .WithOpenApi();
            }
        }

        public static IResult Handler()
        {
            return Results.Ok(new List<Response>()
            {
                new Response(2, "alma", 3000),
                new Response(3, "barack", 3500),
                new Response(4, "banán", 2400),
            });
        }
    }
}
