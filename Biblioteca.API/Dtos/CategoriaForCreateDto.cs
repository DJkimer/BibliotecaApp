using System.ComponentModel.DataAnnotations;

namespace Biblioteca.API.Dtos
{
    public class CategoriaForCreateDto
    {
        [Required]
        [StringLength(50, MinimumLength=1, ErrorMessage="Nombre de libro incorrecto")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(500, MinimumLength=1, ErrorMessage="Descripcion de libro incorrecto")]
        public string Descripcion { get; set; }

    }
}