using S7.Net;

namespace WMS.Infrastructure.PLC
{
    public interface IS7PlcClient
    {
        Task Connect();
        void Disconnect();
        Task<object?> ReadAsync(string address);
        Task WriteAsync(string address, object value);
        Task<byte[]> ReadBytesAsync(DataType dataType, int db, int startByteAdr, int count);

    }
}
