using MediatR;
using WMS.Infrastructure.PLC;

namespace WMS.Application.Features.PLC.Commands.Write;

internal sealed class WritePlcDataCommandHandler(IS7PlcClient plcClient) : IRequestHandler<WritePlcDataCommand>
{
    public async Task Handle(WritePlcDataCommand request, CancellationToken cancellationToken)
    {
        await plcClient.WriteAsync(request.Address, request.Value);
    }
}