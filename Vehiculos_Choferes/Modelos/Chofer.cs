using System.ComponentModel.DataAnnotations;

namespace Vehiculos_Choferes.Modelos
{
    public class Chofer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CiChofer { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string NombreChofer { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string ApellidoChofer { get; set; }

        [Required]
        [Display(Name = "Fecha De Nacimiento")]
        public DateTime FechaNaciminetoChofer { get; set; }

        public int EdadChofer(DateTime fechaDeNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad;

            if (fechaDeNacimiento > fechaActual)
            {
                return -1;
            }
            else
            {
                edad = fechaActual.Year - fechaDeNacimiento.Year;

                if (fechaDeNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                }
            }


            return edad;
        }

    }
}
