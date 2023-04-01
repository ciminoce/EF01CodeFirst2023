namespace EF01CodeFirst2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLugaresDisponiblesFieldInCursosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "LugaresDisponibles", c => c.Int(nullable: false));
            Sql("UPDATE Cursos SET LugaresDisponibles=20");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cursos", "LugaresDisponibles");
        }
    }
}
