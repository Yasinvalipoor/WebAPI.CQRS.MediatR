using MediatR;
using WebAPI.CQRS.MediatR.Models;
namespace WebAPI.CQRS.MediatR.Features.SuperHero.GetSuperHeroesById;

public record GetSuperHeroesByIdQuery(int Id) : IRequest<SuperHeroes?>;    