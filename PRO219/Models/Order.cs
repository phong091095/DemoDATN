namespace Models
{
    public class Order
    {
        public Guid? OrdId { get; set; }              // uniqueidentifier
        public Guid CusId { get; set; }              // uniqueidentifier
        public DateTime OrderDate { get; set; }      // datetime2(7)
        public DateTime StartDate { get; set; }      // datetime2(7)
        public DateTime EndDate { get; set; }        // datetime2(7)
        public int OrderStatus { get; set; }         // int
        public string Note { get; set; }             // nvarchar(255)
        public bool IsDeleted { get; set; }          // bit
        public DateTime CreateDate { get; set; }     // datetime2(7)
        public Guid CreateBy { get; set; }           // uniqueidentifier
        public DateTime? UpdateDate { get; set; }    // datetime2(7), nullable
        public Guid? UpdateBy { get; set; }          // uniqueidentifier, nullable

    }
}
