namespace WMS.BusinessLogic.Dtos.InventoryTransactions;

public class InventoryTransactionDto
{
    public required int TransactionId { get; set; } 
    public required string ProductSku { get; set; } 
    public required string Location { get; set; } 
    public required string InventoryTransactionType { get; set; } 
    public required string Quanlity { get; set; } 
    public required string Status { get; set; } 
    public required string TransactionDate { get; set; } 
    public required string Notes { get; set; } 
}
