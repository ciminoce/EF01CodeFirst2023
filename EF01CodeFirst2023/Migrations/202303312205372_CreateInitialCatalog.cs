namespace EF01CodeFirst2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInitialCatalog : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        CursoId = c.Int(nullable: false, identity: true),
                        NombreCurso = c.String(),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.CursoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cursos");
        }
    }
}
