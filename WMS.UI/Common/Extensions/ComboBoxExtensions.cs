namespace WMS.UI.Common.Extensions;

internal static class ComboBoxExtensions
{
    public static void SetDataSourceWithMembers<TEntity>(
        this ComboBox comboBox,
        IEnumerable<TEntity> dataSource,
        string valueMember,
        string displayMember)
    {
        comboBox.DataSource = null;
        // Set Value
        comboBox.DataSource = dataSource;
        comboBox.ValueMember = valueMember;
        comboBox.DisplayMember = displayMember;
    }
}