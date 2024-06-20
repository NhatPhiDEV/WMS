using MediatR;

namespace WMS.Application.Features.Products.Queries.Export;

public record ExportProductQuery(string FilePath, object Data) : IRequest;