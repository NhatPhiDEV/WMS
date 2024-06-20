using S7.Net;

namespace WMS.Infrastructure.PLC
{
    public class S7PlcClient(string ipAddress, CpuType cpuType, short rack = 0, short slot = 0)
        : IS7PlcClient
    {
        private readonly Plc _plc = new(cpuType, ipAddress, rack, slot);
        private bool _isConnected = false;

        public async Task Connect()
        {
            if (!_isConnected)
            {
                await _plc.OpenAsync();
                _isConnected = true;
            }
        }

        public void Disconnect()
        {
            if (!_isConnected) return;

            _plc.Close();
            _isConnected = false;
        }

        public async Task<object?> ReadAsync(string address) => await _plc.ReadAsync(address);

        public async Task WriteAsync(string address, object value) => await _plc.WriteAsync(address, value);

        public async Task<byte[]> ReadBytesAsync(DataType dataType, int db, int startByteAdr, int count)
        {
            return await _plc.ReadBytesAsync(dataType, db, startByteAdr, count);
        }
    }
}
