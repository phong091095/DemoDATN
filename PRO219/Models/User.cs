
namespace Models
{
    public class User
    {
        public Guid? UserId { get; set; }              // uniqueidentifier
        public int RoleId { get; set; }               // int
        public string UserName { get; set; }          // nvarchar(255)
        public string Password { get; set; }          // nvarchar(MAX)
        public bool IsDeleted { get; set; }           // bit
        public DateTime? CreateDate { get; set; }     // datetime2(7), nullable
        public Guid? CreateBy { get; set; }           // uniqueidentifier, nullable
        public DateTime? UpdateDate { get; set; }     // datetime2(7), nullable
        public Guid? UpdateBy { get; set; }           // uniqueidentifier, nullable
    }
}
