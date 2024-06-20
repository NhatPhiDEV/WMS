using MediatR;
using S7.Net;

namespace WMS.Application.Features.PLC.Queries.ReadBytes;

public record ReadBytesPlcDataQuery(DataType DataType, int Db, int StartByteAdr, int Count) : IRequest<byte[]>;