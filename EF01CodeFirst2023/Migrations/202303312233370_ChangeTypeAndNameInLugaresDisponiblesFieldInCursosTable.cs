namespace EF01CodeFirst2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeAndNameInLugaresDisponiblesFieldInCursosTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "Vacantes", c => c.Byte(nullable: false));
            Sql("UPDATE Cursos SET Vacantes=LugaresDisponibles");
            DropColumn("dbo.Cursos", "LugaresDisponibles");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cursos", "LugaresDisponibles", c => c.Int(nullable: false));
            Sql("UPDATE Cursos SET LugaresDisponibles=Vacantes");

            DropColumn("dbo.Cursos", "Vacantes");
        }
    }
}
