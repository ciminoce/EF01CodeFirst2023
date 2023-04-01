using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01CodeFirst2023.Entidades
{
    [Table("Cursos")]
    public class Curso
    {
        public int CursoId { get; set; }
        [Required]
        [StringLength(50)]
        [Index("IX_Cursos_NombreCurso",IsUnique = true)]
        public string NombreCurso { get; set; }
        [StringLength(200)]
        public string Descripcion { get; set; }

        public decimal PrecioFinal { get; set; }
        public byte Vacantes { get; set; }
        public bool Vigente { get; set; }
        public int CategoriaId { get; set; }

        //Propiedad de navegación
        public virtual  Categoria Categoria { get; set; }
    }
}
