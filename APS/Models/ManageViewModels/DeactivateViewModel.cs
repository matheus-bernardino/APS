using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APS.Models.ManageViewModels
{
    public class DeactivateViewModel
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Password { get; set; }
    }
}
