using MediatR;
using WMS.Infrastructure.Excel;

namespace WMS.Application.Features.Products.Queries.Export;

internal sealed class ExportProductQueryHandler(IExcelService excelService) : IRequestHandler<ExportProductQuery>
{
    public async Task Handle(ExportProductQuery request, CancellationToken cancellationToken)
    {
        await excelService.Export(request.TableData, request.FilePath, request.HeaderText);
    }
}