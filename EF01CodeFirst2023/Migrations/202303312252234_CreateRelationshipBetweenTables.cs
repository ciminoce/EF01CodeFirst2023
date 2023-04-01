namespace EF01CodeFirst2023.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipBetweenTables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cursos", "CategoriaId", c => c.Int(nullable: false));
            Sql("UPDATE Cursos SET CategoriaId=1");
            CreateIndex("dbo.Cursos", "CategoriaId");
            AddForeignKey("dbo.Cursos", "CategoriaId", "dbo.Categorias", "CategoriaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cursos", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Cursos", new[] { "CategoriaId" });
            DropColumn("dbo.Cursos", "CategoriaId");
        }
    }
}
