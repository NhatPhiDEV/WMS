using MediatR;
using WMS.Infrastructure.PLC;

namespace WMS.Application.Features.PLC.Queries.Read;

internal sealed class ReadPlcDataQueryHandler(IS7PlcClient plcClient) : IRequestHandler<ReadPlcDataQuery, object?>
{
    public async Task<object?> Handle(ReadPlcDataQuery request, CancellationToken cancellationToken)
    {
        return await plcClient.ReadAsync(request.Address);
    }
}