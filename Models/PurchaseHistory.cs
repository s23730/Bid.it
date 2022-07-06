using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bid.it.Models
{
	public class PurchaseHistory
	{
        [Key]
        public int IdPurchaseHistory { get; set; }
        [Required]
        public string IdUser { get; set; }
        [ForeignKey("IdUser")]
        public ApplicationUser ApplicationUser { get; set; }
        [Required]
        public int IdAuction { get; set; }
        [ForeignKey("IdAuction")]
        public Auction Auction { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
    }
}

