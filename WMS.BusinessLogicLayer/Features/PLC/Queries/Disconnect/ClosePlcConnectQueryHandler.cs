using MediatR;
using WMS.Infrastructure.PLC;

namespace WMS.Application.Features.PLC.Queries.Disconnect;

internal sealed class ClosePlcConnectQueryHandler(IS7PlcClient plcClient) : IRequestHandler<ClosePlcConnectQuery>
{
    public Task Handle(ClosePlcConnectQuery request, CancellationToken cancellationToken)
    {
        plcClient.Disconnect();
        return Task.FromResult(Unit.Value);
    }
}