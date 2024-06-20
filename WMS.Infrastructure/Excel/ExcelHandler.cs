using OfficeOpenXml.Table;
using OfficeOpenXml;
using System.Data;

namespace WMS.Infrastructure.Excel;

public class ExcelHandler : IExcel
{
    public async Task ExportAsync(string filePath, object data)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using var package = new ExcelPackage();
        var worksheet = package.Workbook.Worksheets.Add("DuLieu");

        switch (data)
        {
            case DataTable dataTable:
                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true, TableStyles.Light1);
                break;
            case IEnumerable<object> enumerable:
                worksheet.Cells["A1"].LoadFromCollection(enumerable, true, TableStyles.Light1);
                break;
            default:
                throw new ArgumentException("Unsupported data type");
        }

        worksheet.Cells.AutoFitColumns();

        await package.SaveAsAsync(new FileInfo(filePath));
    }
}