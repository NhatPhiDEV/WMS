namespace WMS.BusinessLogic.Dtos.Base;

public class SelectorDto
{
    public required object Key { get; set; }
    public required object Value { get; set; }
    public object AdditionalValue { get; set; } = string.Empty;
}
