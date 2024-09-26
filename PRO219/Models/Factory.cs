
namespace Models
{
    public class Factory
    {
        public Guid? FactoryId { get; set; }          // uniqueidentifier
        public string FactoryName { get; set; }      // nvarchar(250)
        public string Note { get; set; }             // nvarchar(MAX)
        public bool IsDeleted { get; set; }          // bit
        public DateTime CreateDate { get; set; }     // datetime2(7)
        public Guid CreateBy { get; set; }           // uniqueidentifier
        public DateTime? UpdateDate { get; set; }    // datetime2(7), nullable
        public Guid? UpdateBy { get; set; }          // uniqueidentifier, nullable
    }
}
