using MediatR;
namespace WebAPI.CQRS.MediatR.Features.SuperHero.CreateSuperHeroes;

public record CreateSuperHeroesCommand(string Name, int Rate) : IRequest<int>;