
namespace Models
{
    public class OrderDetail
    {
        public Guid? OrddId { get; set; }             // uniqueidentifier
        public Guid OrdId { get; set; }              // uniqueidentifier
        public Guid ProId { get; set; }              // uniqueidentifier
        public int Quantity { get; set; }            // int
        public decimal Price { get; set; }           // money
        public string Note { get; set; }             // nvarchar(MAX)
        public bool IsDeleted { get; set; }          // bit
        public DateTime CreateDate { get; set; }     // datetime2(7)
        public Guid CreateBy { get; set; }           // uniqueidentifier
        public DateTime? UpdateDate { get; set; }    // datetime2(7), nullable
        public Guid? UpdateBy { get; set; }          // uniqueidentifier, nullable
    }
}
