using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APS.Models
{
    public class Book
    {

        public Guid BookId { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9""'\s-]*$", ErrorMessage ="Valor de campo inválido")]
        [StringLength(50)]
        [Required(ErrorMessage = "Campo Título obrigatório")]
        public string Title { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required(ErrorMessage = "Campo Autor obrigatório")]
        public string Author { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required(ErrorMessage = "Campo  Editora obrigatório")]
        public string PublishingCompany { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(50)]
        [Required(ErrorMessage = "Campo Categoria obrigatório")]
        public string Category { get; set; }
        [Range(0, double.MaxValue)]
        [Required(ErrorMessage = "Campo Preço obrigatório")]
        public decimal? Value { get; set; }
        [Range(1, int.MaxValue)]
        [Required(ErrorMessage = "Entre com um valor válido")]
        public int? InitialStock { get; set; }
        public int? InStock { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public bool BookStatus { get; set; } = true;

        public string SellerId { get; set; }
		public ApplicationUser ApplicationUser { get; set; }
		//public Purchase Purchase { get; set; }


	}
}