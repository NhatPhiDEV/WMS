using MediatR;

namespace WMS.Application.Features.PLC.Queries.Read;

public record ReadPlcDataQuery(string Address) : IRequest<object?>;