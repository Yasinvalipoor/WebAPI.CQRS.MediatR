using MediatR;
using WebAPI.CQRS.MediatR.Data;
using WebAPI.CQRS.MediatR.Models;
namespace WebAPI.CQRS.MediatR.Features.SuperHero.GetSuperHeroesById;

public class GetSuperHeroesByIdQueryHandler : IRequestHandler<GetSuperHeroesByIdQuery, SuperHeroes?>
{
    private readonly SuperHeroesAppDbContext _context;
    public GetSuperHeroesByIdQueryHandler(SuperHeroesAppDbContext context)
    {
        _context = context;
    }
    public async Task<SuperHeroes?> Handle(GetSuperHeroesByIdQuery request, CancellationToken cancellationToken)
    {
        var superHeroes = await _context.SuperHeroes.FindAsync(request.Id);
        return superHeroes;
    }
}