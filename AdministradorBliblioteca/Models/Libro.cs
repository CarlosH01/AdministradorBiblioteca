using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AdministradorBliblioteca.Models
{
    public class Libro
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El título es obligatorio."), MaxLength(150)]
        public string Titulo { get; set; }
        [MaxLength(100)]
        public string Autor { get; set; }
        [Range(1450, 2100, ErrorMessage = "El año de publicación debe estar entre 1450 y 2100.")]
        public int AnioPublicacion { get; set; }
        [Precision(10, 2)]
        public decimal Precio { get; set; }
        public bool Disponible { get; set; }
    }
}
