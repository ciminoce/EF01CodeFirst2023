namespace EF01CodeFirst2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVigenteFieldInCursosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "Vigente", c => c.Boolean(nullable: false));
            Sql("UPDATE Cursos SET Vigente=1");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cursos", "Vigente");
        }
    }
}
