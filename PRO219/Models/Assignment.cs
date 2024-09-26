
namespace Models
{
    public class Assignment
    {
        public Guid? AssId { get; set; }              // uniqueidentifier
        public Guid OrddId { get; set; }             // uniqueidentifier
        public Guid LeId { get; set; }               // uniqueidentifier
        public int AssignedQuantity { get; set; }    // int
        public int DoneQuantity { get; set; }        // int
        public int ErrorQuantity { get; set; }       // int
        public decimal Price { get; set; }           // money
        public int StatusId { get; set; }            // int
        public string Note { get; set; }             // nvarchar(MAX)
        public bool IsDeleted { get; set; }          // bit
        public DateTime CreateDate { get; set; }     // datetime2(7)
        public Guid CreateBy { get; set; }           // uniqueidentifier
        public DateTime? UpdateDate { get; set; }    // datetime2(7), nullable
        public Guid? UpdateBy { get; set; }          // uniqueidentifier, nullable
    }
}
