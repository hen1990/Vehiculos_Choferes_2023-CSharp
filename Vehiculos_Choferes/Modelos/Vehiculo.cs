using System.ComponentModel.DataAnnotations;

namespace Vehiculos_Choferes.Modelos
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Matricula { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public string Modelo { get; set; }

        [Required]
        [Display(Name = "Año")]
        public DateTime Anio { get; set; }

    }
}
