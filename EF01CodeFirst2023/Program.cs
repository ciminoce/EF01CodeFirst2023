using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF01CodeFirst2023.Datos;

namespace EF01CodeFirst2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetCursos();
            Console.ReadLine();
        }

        private static void GetCursos()
        {
            using (var context = new CursosDbContext())
            {
                var listaCursos = context.Cursos.ToList();
                foreach (var curso in listaCursos)
                {
                    Console.WriteLine($"{curso.CursoId}-{curso.NombreCurso}");
                }
            }
        }
    }
}
