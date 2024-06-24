using MediatR;
using WMS.Domain.Models;

namespace WMS.Application.Features.Products.Queries.Export;

public record ExportProductQuery(TableData TableData, string FilePath, string HeaderText) : IRequest;