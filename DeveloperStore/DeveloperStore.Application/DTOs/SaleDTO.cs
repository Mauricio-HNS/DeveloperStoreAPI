namespace DeveloperStore.API.DTOs
{
    public class SaleDTO
    {
        public int SaleNumber { get; set; }
        public DateTime SaleDate { get; set; }
        public CustomerDTO Customer { get; set; }
        public decimal TotalAmount { get; set; }
        public BranchDTO Branch { get; set; }
        public List<SaleItemDTO> SaleItems { get; set; }
        public bool IsCancelled { get; set; }
    }
}

