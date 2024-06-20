using MediatR;

namespace WMS.Application.Features.PLC.Commands.Write;

public record WritePlcDataCommand(string Address, object Value) : IRequest;