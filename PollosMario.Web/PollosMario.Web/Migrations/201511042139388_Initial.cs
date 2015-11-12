namespace PollosMario.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        Direccion = c.String(),
                        Telefono = c.String(),
                        PersonaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.PersonaId, cascadeDelete: true)
                .Index(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidoes", "PersonaId", "dbo.Personas");
            DropIndex("dbo.Pedidoes", new[] { "PersonaId" });
            DropTable("dbo.Pedidoes");
        }
    }
}
