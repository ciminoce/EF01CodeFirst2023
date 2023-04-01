namespace EF01CodeFirst2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInFieldsCursosTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cursos", "NombreCurso", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cursos", "Descripcion", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cursos", "Descripcion", c => c.String());
            AlterColumn("dbo.Cursos", "NombreCurso", c => c.String());
        }
    }
}
