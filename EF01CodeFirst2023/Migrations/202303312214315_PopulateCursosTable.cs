namespace EF01CodeFirst2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCursosTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CURSOS (NombreCurso, Descripcion) VALUES('C# Básico','Primeros pasos con el lenguaje') ");
            Sql("INSERT INTO CURSOS (NombreCurso, Descripcion) VALUES('C# Intermedio','') ");
            Sql("INSERT INTO CURSOS (NombreCurso, Descripcion) VALUES('C# Avanzado','Técnicas superiores del uso del lenguaje') ");

        }

        public override void Down()
        {
            Sql("DELETE FROM Cursos");
        }
    }
}
