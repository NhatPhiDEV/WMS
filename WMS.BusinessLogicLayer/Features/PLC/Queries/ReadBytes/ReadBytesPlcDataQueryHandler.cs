using MediatR;
using WMS.Infrastructure.PLC;

namespace WMS.Application.Features.PLC.Queries.ReadBytes
{
    internal sealed class ReadBytesPlcDataQueryHandler(IS7PlcClient plcClient)
        : IRequestHandler<ReadBytesPlcDataQuery, byte[]>
    {
        public async Task<byte[]> Handle(ReadBytesPlcDataQuery request, CancellationToken cancellationToken)
        {
            return await plcClient.ReadBytesAsync(request.DataType, request.Db, request.StartByteAdr, request.Count);
        }
    }
}
