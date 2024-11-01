using MediatR;
using WebAPI.CQRS.MediatR.Data;
using WebAPI.CQRS.MediatR.Models;
namespace WebAPI.CQRS.MediatR.Features.SuperHero.CreateSuperHeroes;

public class CreateSuperHeroesCommandHandler : IRequestHandler<CreateSuperHeroesCommand, int>
{
    private readonly SuperHeroesAppDbContext _context;
    public CreateSuperHeroesCommandHandler(SuperHeroesAppDbContext context)
    {
        _context = context;
    }
    public async Task<int> Handle(CreateSuperHeroesCommand request, CancellationToken cancellationToken)
    {
        var heroes = new SuperHeroes { Name = request.Name, Rate = request.Rate };
        _context.SuperHeroes.Add(heroes);
        await _context.SaveChangesAsync();

        return heroes.Id;
    }
}