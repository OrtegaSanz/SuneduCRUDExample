namespace SuneduCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Docentes",
                c => new
                    {
                        DocenteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                        Dni = c.Int(nullable: false),
                        Sexo = c.String(),
                        Estudios = c.String(),
                        EstadoContratacion = c.Int(nullable: false),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Otro = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.DocenteId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Docentes");
        }
    }
}
