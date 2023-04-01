using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EF01CodeFirst2023.Entidades
{
    [Table("Categorias")]
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required]
        [StringLength(50)]
        [Index("IX_Categorias_NombreCategoria",IsUnique = true)]
        public string NombreCategoria { get; set; }

        public virtual ICollection<Curso> Cursos { get; set; }

    }
}
