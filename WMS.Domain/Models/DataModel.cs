namespace WMS.Domain.Models;

public class TableData
{
    public required string[] Headers { get; set; }
    public required string[][] Rows { get; set; }
}