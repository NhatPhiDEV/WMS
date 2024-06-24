using MediatR;
using WMS.Infrastructure.Repositories.Core;
using WMS.Infrastructure.Uow;

namespace WMS.Application.Features.Locations.Queries.CheckLocationExists;

internal sealed class CheckLocationExistsQueryHandler (IUnitOfWork unitOfWork)
    : IRequestHandler<CheckLocationExistsQuery, bool>
{
    public Task<bool> Handle(CheckLocationExistsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}