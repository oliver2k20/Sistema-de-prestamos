namespace TableHtml.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rt : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.clientes");
        }
    }
}
