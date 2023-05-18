using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace POS_SuperStore.ViewModel
{
	public class InventoryDetailVM
	{			 
		 public Guid RequestId { get; set; }
		public string ItemCategory { get; set; }
		public string ItemName { get; set; }
		public string ItemCode { get; set; }
		public int RequestBy { get; set; }
		public DateTime RequestDate { get; set; }
		public int Quantity { get; set; }
	    public string status { get; set; }
		public string? Description { get; set; }
		public string? SpecialInstruction { get; set; }
		 
		 
	}
}
