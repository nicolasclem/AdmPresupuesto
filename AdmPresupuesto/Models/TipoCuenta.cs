using System.ComponentModel.DataAnnotations;

namespace AdmPresupuesto.Models
{
    public class TipoCuenta
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        [StringLength(maximumLength: 50,MinimumLength = 3 ,ErrorMessage =" El campo {0} debe tener entre {2} y {1} caracteres")]
        [Display(Name ="Nombre del tipo cuenta")]
        public string Nombre { get; set; }

        public int UsuarioId { get; set; }

        public int Orden { get; set; }


        /*
         Validaciones por defecto
         
        [EmailAddress(ErrorMessage = "El campo {0} es requerido")]
        [Range(minimum:18, maximum:99,ErrorMessage = " El campo {0} debe estar entre {1} y {2} ")]
        [Url(ErrorMessage = "El campo {0} debe ser una url valida")]
        [CreditCard(ErrorMessage = "El campo {0} debe ser valido")]
        */
    }
}
