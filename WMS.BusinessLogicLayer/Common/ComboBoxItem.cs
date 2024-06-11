namespace WMS.Application.Common;

public record ComboBoxItem
{
    public required object Key { get; set; }
    public required object Val { get; set; }
    public object AdditionalValue { get; set; } = string.Empty;

};