using WMS.Domain.Models;

namespace WMS.Infrastructure.Excel;

public interface IExcelService
{
    Task Export(TableData tableData, string filePath, string headerText);
}