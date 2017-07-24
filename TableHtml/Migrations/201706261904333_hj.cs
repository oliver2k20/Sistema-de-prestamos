namespace TableHtml.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hj : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.prestamoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Int(nullable: false),
                        Percentage = c.Single(nullable: false),
                        FechadelPrestamo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.clientes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        FechadeNacimiento = c.DateTime(nullable: false),
                        EstadoCivil = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.prestamoes");
        }
    }
}
