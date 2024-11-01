namespace WebAPI.CQRS.MediatR.Models;

public class SuperHeroes
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Rate { get; set; }
};


//public static class SuperHeroesEndpoints
//{
//	public static void MapSuperHeroesEndpoints (this IEndpointRouteBuilder routes)
//    {
//        var group = routes.MapGroup("/api/SuperHeroes").WithTags(nameof(SuperHeroes));

//        group.MapGet("/", async (SuperHeroesAppDbContext db) =>
//        {
//            return await db.SuperHeroes.ToListAsync();
//        })
//        .WithName("GetAllSuperHeroes")
//        .WithOpenApi();

//        group.MapGet("/{id}", async Task<Results<Ok<SuperHeroes>, NotFound>> (int id, SuperHeroesAppDbContext db) =>
//        {
//            return await db.SuperHeroes.AsNoTracking()
//                .FirstOrDefaultAsync(model => model.Id == id)
//                is SuperHeroes model
//                    ? TypedResults.Ok(model)
//                    : TypedResults.NotFound();
//        })
//        .WithName("GetSuperHeroesById")
//        .WithOpenApi();

//        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, SuperHeroes superHeroes, SuperHeroesAppDbContext db) =>
//        {
//            var affected = await db.SuperHeroes
//                .Where(model => model.Id == id)
//                .ExecuteUpdateAsync(setters => setters
//                  .SetProperty(m => m.Id, superHeroes.Id)
//                  .SetProperty(m => m.Name, superHeroes.Name)
//                  .SetProperty(m => m.Rate, superHeroes.Rate)
//                  );
//            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
//        })
//        .WithName("UpdateSuperHeroes")
//        .WithOpenApi();

//        group.MapPost("/", async (SuperHeroes superHeroes, SuperHeroesAppDbContext db) =>
//        {
//            db.SuperHeroes.Add(superHeroes);
//            await db.SaveChangesAsync();
//            return TypedResults.Created($"/api/SuperHeroes/{superHeroes.Id}",superHeroes);
//        })
//        .WithName("CreateSuperHeroes")
//        .WithOpenApi();

//        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, SuperHeroesAppDbContext db) =>
//        {
//            var affected = await db.SuperHeroes
//                .Where(model => model.Id == id)
//                .ExecuteDeleteAsync();
//            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
//        })
//        .WithName("DeleteSuperHeroes")
//        .WithOpenApi();
//    }
//}