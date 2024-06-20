using MediatR;
using WMS.Infrastructure.Excel;

namespace WMS.Application.Features.Products.Queries.Export
{
    internal sealed class ExportProductQueryHandler(IExcel excel) : IRequestHandler<ExportProductQuery>
    {
        public async Task Handle(ExportProductQuery request, CancellationToken cancellationToken)
        {
            await excel.ExportAsync(request.FilePath, request.Data);
        }
    }
}
