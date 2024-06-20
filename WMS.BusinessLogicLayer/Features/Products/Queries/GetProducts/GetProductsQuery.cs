using MediatR;
using WMS.Domain.Models;
using WMS.Domain.Shared.Pagination;

namespace WMS.Application.Features.Products.Queries.GetProducts;

public record GetProductsQuery(string SearchTemp, int Page, int PageSize) : IRequest<IPagedList<Product>>;