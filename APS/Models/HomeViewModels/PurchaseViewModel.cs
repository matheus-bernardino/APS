using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Models.HomeViewModels
{
    public class PurchaseViewModel
    {
        public Purchase Purchase { get; set; }
        [RegularExpression(@"^[0-9""'\s-]*$", ErrorMessage = "Valor de campo inválido")]
        [StringLength(8)]
        [Required(ErrorMessage = "Campo Título obrigatório")]
        public string CardNumber { get; set; }
        [RegularExpression(@"^[0-9""'\s-]*$", ErrorMessage = "Valor de campo inválido")]
        [StringLength(3)]
        [Required(ErrorMessage = "Campo Título obrigatório")]
        public string SecureCode { get; set; }
        [RegularExpression(@"^[A-Z""'\s-]*$", ErrorMessage = "Valor de campo inválido")]
        [StringLength(50)]
        [Required(ErrorMessage = "Campo Título obrigatório")]
        public string Owner { get; set; }
    }
}
