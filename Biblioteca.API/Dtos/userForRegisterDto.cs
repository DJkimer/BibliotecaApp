using System.ComponentModel.DataAnnotations;

namespace Biblioteca.API.Dtos
{
    public class userForRegisterDto
    {
        [Required]
        [StringLength(30,MinimumLength = 3,ErrorMessage="Usarname incorrecto")]
        public string Username{get;set;}

        [Required]
        [StringLength(30,MinimumLength = 3,ErrorMessage="clave no soportada")]
        public string Password{get;set;}
    }
}