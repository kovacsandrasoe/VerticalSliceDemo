
namespace VerticalSliceDemo.Product
{
    public class CreateProduct
    {
        public record Request(string Name, int Price);
        public record Response(int Id, string Name, int Price);

        public sealed class Endpoint : IEndpoint
        {
            public void MapEndpoint(IEndpointRouteBuilder app)
            {
                app
                    .MapPost("product", Handler)
                    .WithTags("Product")
                    .Produces<Response>()
                    .WithOpenApi();
            }
        }

        public static IResult Handler(Request request)
        {
            return Results.Ok(new Response(1, request.Name, request.Price));
        }
    }
}
