using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prog5_1C_2K26.Models
{
    public class CentroVacunacion
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [DisplayName("Provincia")]
        [Range(1, 7, ErrorMessage = "Los valores de las provincias deben estar entre 1 y 7")]
        public int ProvinciaId { get; set; }

        public CentroVacunacion()
        {
        }
    }
}
