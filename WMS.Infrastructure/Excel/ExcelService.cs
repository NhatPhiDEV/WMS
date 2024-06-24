using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;
using WMS.Domain.Models;

namespace WMS.Infrastructure.Excel;

public class ExcelService : IExcelService
{
    public async Task Export(TableData tableData, string filePath, string headerText)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("DuLieu");

            // Thêm và merge hàng tiêu đề
            worksheet.InsertRow(1, 1);
            worksheet.Cells[1, 1, 1, tableData.Headers.Length].Merge = true;

            // Định dạng và điền nội dung tiêu đề
            using (var titleRange = worksheet.Cells[1, 1])
            {
                titleRange.Value = headerText;
                titleRange.Style.Font.Name = "Times New Roman";
                titleRange.Style.Font.Size = 15;
                titleRange.Style.Font.Bold = true;
                titleRange.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                titleRange.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                titleRange.Style.Fill.PatternType = ExcelFillStyle.Solid;
                titleRange.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(0, 112, 192)); // Màu xanh nước biển
            }

            // Ghi header và trang trí (Bắt đầu từ dòng 2)
            for (var i = 0; i < tableData.Headers.Length; i++)
            {
                var cell = worksheet.Cells[2, i + 1]; // Ghi vào hàng 2
                cell.Value = tableData.Headers[i];
                cell.Style.Font.Bold = true;
                cell.Style.Font.Name = "Times New Roman";
                cell.Style.Font.Size = 13;
                cell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                cell.Style.Fill.BackgroundColor.SetColor(Color.LightGray);
                cell.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                cell.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                cell.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                cell.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            }

            // Định dạng toàn bộ bảng dữ liệu (bắt đầu từ dòng 3)
            using (var range = worksheet.Cells[3, 1, tableData.Rows.Length + 3, tableData.Headers.Length])
            {
                range.Style.Font.Name = "Times New Roman";
                range.Style.Font.Size = 13;
                range.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                range.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            }

            // Ghi dữ liệu và chuyển đổi kiểu bool (bắt đầu từ dòng 3)
            for (var i = 0; i < tableData.Rows.Length; i++)
            {
                for (var j = 0; j < tableData.Rows[i].Length; j++)
                {
                    var value = tableData.Rows[i][j];
                    if (bool.TryParse(value, out bool boolValue))
                    {
                        worksheet.Cells[i + 3, j + 1].Value = boolValue ? "Có" : "Không";
                    }
                    else
                    {
                        worksheet.Cells[i + 3, j + 1].Value = value;
                    }
                }
            }

            // Format và lưu file
            var fileInfo = new FileInfo(filePath);
            worksheet.Cells.AutoFitColumns();
            await package.SaveAsAsync(fileInfo);
        }
    }
}