
namespace Models
{
    public class Customer
    {
        public Guid? CusId { get; set; }              // uniqueidentifier
        public string LastName { get; set; }          // nvarchar(100)
        public string FirstName { get; set; }         // nvarchar(100)
        public string CompanyName { get; set; }       // nvarchar(250)
        public string Phone { get; set; }             // nvarchar(50)
        public string Email { get; set; }             // nvarchar(255)
        public string Address { get; set; }           // nvarchar(255)
        public bool IsDeleted { get; set; }           // bit
        public DateTime CreateDate { get; set; }      // datetime2(7)
        public Guid CreateBy { get; set; }            // uniqueidentifier
        public DateTime? UpdateDate { get; set; }     // datetime2(7), nullable
        public Guid? UpdateBy { get; set; }           // uniqueidentifier, nullable
    }
}

