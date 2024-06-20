namespace WMS.Domain.Enums;

public enum EInventoryTransactionStatus
{
    Pending = 0,
    Completed = 1,
    Cancelled = 2
}

public enum EInventoryTransactionTypes
{
    None = 0,
    In = 1,
    Out = 2
}

public enum ETabControls
{
    TabDashboard,
    TabLocation
}

public enum EDashboardGvProcess
{
    GvProcessColCheckBox = 0,
    GvProcessColStt = 1,
    GvProcessColSku = 2,
    GvProcessColTransactionType = 3,
    GvProcessColLocation = 4,
    GvProcessColQuantity = 5,
    GvProcessColLocationId = 6,
    GvProcessColTransactionTypeId = 7
}
