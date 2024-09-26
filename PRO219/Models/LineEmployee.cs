
namespace Models
{
    public class LineEmployee
    {
        public Guid? LeId { get; set; }               // uniqueidentifier
        public Guid LineId { get; set; }             // uniqueidentifier
        public Guid EmpId { get; set; }              // uniqueidentifier
        public bool IsCaptain { get; set; }          // bit
        public bool IsDeleted { get; set; }          // bit
        public DateTime CreateDate { get; set; }     // datetime2(7)
        public Guid CreateBy { get; set; }           // uniqueidentifier
        public DateTime? UpdateDate { get; set; }    // datetime2(7), nullable
        public Guid? UpdateBy { get; set; }          // uniqueidentifier, nullable
    }
}
