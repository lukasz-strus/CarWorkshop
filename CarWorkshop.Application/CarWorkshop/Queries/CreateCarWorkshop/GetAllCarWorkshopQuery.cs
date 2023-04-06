using MediatR;

namespace CarWorkshop.Application.CarWorkshop.Queries.CreateCarWorkshop;

public class GetAllCarWorkshopQuery : IRequest<IEnumerable<CarWorkshopDto>>
{
}