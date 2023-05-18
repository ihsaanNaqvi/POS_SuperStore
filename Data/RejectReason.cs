using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace POS_SuperStore.Data
{
    [Table("Rejection")]
    public class RejectReason : TransactionalBaseModel
    {
        [Key]
        public Guid RejectionId { get; set; }
        public Guid ReferenceId { get; set; }
        public string Reason { get; set; }
    }
    public class TransactionalBaseModel
	{
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string? ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public string? DeletedBy { get; set; }
		public DateTime? DeletedDate { get; set; }
		public bool IsDeleted { get; set; }
	}
}
