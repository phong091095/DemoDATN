
namespace Models
{
    public class Line
    {
        public Guid? LineId { get; set; }             // uniqueidentifier
        public Guid FactoryId { get; set; }          // uniqueidentifier
        public string LineName { get; set; }         // nvarchar(250)
        public string Note { get; set; }             // nvarchar(MAX)
        public bool IsDeleted { get; set; }          // bit
        public DateTime CreateDate { get; set; }     // datetime2(7)
        public Guid CreateBy { get; set; }           // uniqueidentifier
        public DateTime? UpdateDate { get; set; }    // datetime2(7), nullable
        public Guid? UpdateBy { get; set; }          // uniqueidentifier, nullable
    }
}
