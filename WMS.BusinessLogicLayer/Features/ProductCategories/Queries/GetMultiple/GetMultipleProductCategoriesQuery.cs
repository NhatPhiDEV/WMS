using MediatR;
using WMS.Application.Common;

namespace WMS.Application.Features.ProductCategories.Queries.GetMultiple;

public record GetMultipleProductCategoriesQuery : IRequest<IEnumerable<ComboBoxItem>>;