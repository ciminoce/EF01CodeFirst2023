namespace EF01CodeFirst2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateIndexInCursosTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cursos", "NombreCurso", unique: true, name: "IX_Cursos_NombreCurso");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cursos", "IX_Cursos_NombreCurso");
        }
    }
}
