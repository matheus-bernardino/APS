using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using APS.Models;

namespace APS.Models
{
	public class Purchase
	{
        public Guid PurchaseId { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Valor de campo inválido")]
        [StringLength(50)]
        [Required(ErrorMessage = "Campo Título obrigatório")]
        public string Street { get; set; }
        [RegularExpression(@"^[0-9""'\s-]*$", ErrorMessage = "Valor de campo inválido")]
        [StringLength(50)]
        [Required(ErrorMessage = "Campo Título obrigatório")]
        public string Number { get; set; }
        public bool CardType { get; set; } = true;
        public int Rating { get; set; }
        public string Status { get; set; }

        public string BuyerId { get; set; }
        public ApplicationUser Buyer { get; set; }
        public string SellerId { get; set; }
        public ApplicationUser Seller { get; set; }
        public string ItemId { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
    }
}