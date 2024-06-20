using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Infrastructure.Excel
{
    public interface IExcel
    {
        Task ExportAsync(string filePath, object data);
    }
}
