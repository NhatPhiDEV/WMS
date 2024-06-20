using MediatR;
using WMS.Infrastructure.PLC;

namespace WMS.Application.Features.PLC.Queries.Connect
{
    internal sealed class OpenPlcConnectQueryHandler(IS7PlcClient plcClient) : IRequestHandler<OpenPlcConnectQuery>
    {
        public async Task Handle(OpenPlcConnectQuery request, CancellationToken cancellationToken)
        {
            try
            {
                await plcClient.Connect();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}